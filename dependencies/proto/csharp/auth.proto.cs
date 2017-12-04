//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: auth.proto
namespace NPx
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AuthenticateWithKeyMessage")]
  public partial class AuthenticateWithKeyMessage : global::ProtoBuf.IExtensible
  {
    public AuthenticateWithKeyMessage() {}
    
    private string _licenseKey;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"licenseKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string licenseKey
    {
      get { return _licenseKey; }
      set { _licenseKey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AuthenticateWithDetailsMessage")]
  public partial class AuthenticateWithDetailsMessage : global::ProtoBuf.IExtensible
  {
    public AuthenticateWithDetailsMessage() {}
    
    private string _username;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"username", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string username
    {
      get { return _username; }
      set { _username = value; }
    }
    private string _password;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AuthenticateWithTokenMessage")]
  public partial class AuthenticateWithTokenMessage : global::ProtoBuf.IExtensible
  {
    public AuthenticateWithTokenMessage() {}
    
    private byte[] _token;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] token
    {
      get { return _token; }
      set { _token = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AuthenticateResultMessage")]
  public partial class AuthenticateResultMessage : global::ProtoBuf.IExtensible
  {
    public AuthenticateResultMessage() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private ulong _npid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"npid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong npid
    {
      get { return _npid; }
      set { _npid = value; }
    }
    private byte[] _sessionToken;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"sessionToken", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] sessionToken
    {
      get { return _sessionToken; }
      set { _sessionToken = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AuthenticateUserGroupMessage")]
  public partial class AuthenticateUserGroupMessage : global::ProtoBuf.IExtensible
  {
    public AuthenticateUserGroupMessage() {}
    
    private int _groupID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"groupID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int groupID
    {
      get { return _groupID; }
      set { _groupID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AuthenticateValidateTicketMessage")]
  public partial class AuthenticateValidateTicketMessage : global::ProtoBuf.IExtensible
  {
    public AuthenticateValidateTicketMessage() {}
    
    private uint _clientIP;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"clientIP", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint clientIP
    {
      get { return _clientIP; }
      set { _clientIP = value; }
    }
    private ulong _npid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"npid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong npid
    {
      get { return _npid; }
      set { _npid = value; }
    }
    private byte[] _ticket;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ticket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] ticket
    {
      get { return _ticket; }
      set { _ticket = value; }
    }

    private string _name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AuthenticateValidateTicketResultMessage")]
  public partial class AuthenticateValidateTicketResultMessage : global::ProtoBuf.IExtensible
  {
    public AuthenticateValidateTicketResultMessage() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private ulong _npid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"npid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong npid
    {
      get { return _npid; }
      set { _npid = value; }
    }
    private int _groupID;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"groupID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int groupID
    {
      get { return _groupID; }
      set { _groupID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AuthenticateKickUserMessage")]
  public partial class AuthenticateKickUserMessage : global::ProtoBuf.IExtensible
  {
    public AuthenticateKickUserMessage() {}
    
    private ulong _npid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"npid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong npid
    {
      get { return _npid; }
      set { _npid = value; }
    }
    private int _reason;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int reason
    {
      get { return _reason; }
      set { _reason = value; }
    }
    private string _reasonString;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"reasonString", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string reasonString
    {
      get { return _reasonString; }
      set { _reasonString = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AuthenticateExternalStatusMessage")]
  public partial class AuthenticateExternalStatusMessage : global::ProtoBuf.IExtensible
  {
    public AuthenticateExternalStatusMessage() {}
    
    private int _status;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AuthenticateRegisterServerMessage")]
  public partial class AuthenticateRegisterServerMessage : global::ProtoBuf.IExtensible
  {
    public AuthenticateRegisterServerMessage() {}
    

    private string _configPath = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"configPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string configPath
    {
      get { return _configPath; }
      set { _configPath = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AuthenticateRegisterServerResultMessage")]
  public partial class AuthenticateRegisterServerResultMessage : global::ProtoBuf.IExtensible
  {
    public AuthenticateRegisterServerResultMessage() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private string _licenseKey;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"licenseKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string licenseKey
    {
      get { return _licenseKey; }
      set { _licenseKey = value; }
    }
    private int _serverID;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"serverID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int serverID
    {
      get { return _serverID; }
      set { _serverID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}