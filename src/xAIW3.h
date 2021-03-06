#include "windows.h"
#include "Psapi.h"
#include <algorithm>

#pragma comment( lib, "psapi.lib" )

void CI_SendStatus(const char* status);

unsigned char xaiw3_bytes[64] =
{
	0xE9, 0x56, 0x0B, 0x00, 0x00, 0x00, 0x58, 0x05, 0x5A, 0x0B, 0x00, 0x00, 0x8B, 0x30, 0x03, 0xF0,
	0x2B, 0xC0, 0x8B, 0xFE, 0x66, 0xAD, 0xC1, 0xE0, 0x0C, 0x8B, 0xC8, 0x50, 0xAD, 0x2B, 0xC8, 0x03,
	0xF1, 0x8B, 0xC8, 0x57, 0x51, 0x49, 0x8A, 0x44, 0x39, 0x06, 0x88, 0x04, 0x31, 0x75, 0xF6, 0x2B,
	0xC0, 0xAC, 0x8B, 0xC8, 0x80, 0xE1, 0xF0, 0x24, 0x0F, 0xC1, 0xE1, 0x0C, 0x8A, 0xE8, 0xAC, 0x0B
};

unsigned char keller_hook_bytes[64] =
{
	0xE8, 0x1C, 0x00, 0x00, 0x00, 0x53, 0x61, 0x66, 0x65, 0x6E, 0x67, 0x69, 0x6E, 0x65, 0x20, 0x53,
	0x68, 0x69, 0x65, 0x6C, 0x64, 0x65, 0x6E, 0x20, 0x76, 0x32, 0x2E, 0x33, 0x2E, 0x30, 0x2E, 0x30,
	0x00, 0xE9, 0x24, 0xFD, 0xFF, 0xFF, 0x57, 0xFF, 0x74, 0x24, 0x03, 0xFF, 0x74, 0x24, 0x01, 0xE8,
	0x2F, 0x00, 0x00, 0x00, 0x7C, 0x3A, 0x67, 0x2D, 0xF3, 0xCA, 0x4F, 0xD6, 0xF5, 0x66, 0x89, 0x7C
};

DWORD __stdcall hack_detection_thread(LPVOID)
{
	HMODULE hmodule_array[128];
	HANDLE  process_handle;
	DWORD   cbNeeded;
	_MODULEINFO module_info_struct;

	unsigned char char_array[64];
	unsigned int matches;

	process_handle = GetCurrentProcess();

	while (1)
	{
		std::fill_n(hmodule_array, 128, (HMODULE) 0);
		std::fill_n(char_array, 64, 0x00);
		
		cbNeeded = 0;

		EnumProcessModules(process_handle, hmodule_array, sizeof(hmodule_array), &cbNeeded);

		for (unsigned int i = 0; i < (cbNeeded / sizeof (HMODULE)); ++i)
		{
			GetModuleInformation(process_handle, hmodule_array[i], &module_info_struct, sizeof(module_info_struct));
			ReadProcessMemory(process_handle, module_info_struct.EntryPoint, char_array, 64, NULL);

			matches = 0;

			for (unsigned int i = 0; i < 64; ++i)
			{
				if (xaiw3_bytes[i] == char_array[i])
				{
					++matches;
				}
			}

			if (matches == 64)
			{
					("aci 30004");
				return 1;
			}

			matches = 0;

			for (unsigned int i = 0; i < 64; ++i)
			{
				if (keller_hook_bytes[i] == char_array[i])
				{
					++matches;
				}
			}

			if (matches == 64)
			{
				CI_SendStatus("aci 30004");
				return 1;
			}
		}

		Sleep(10000);
	}

	return 0;
}