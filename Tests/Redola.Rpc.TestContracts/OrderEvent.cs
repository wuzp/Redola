//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Tests/Redola.Rpc.TestContracts/OrderEvent.proto
namespace Redola.Rpc.TestContracts
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OrderDeliveredNotification")]
  public partial class OrderDeliveredNotification : global::ProtoBuf.IExtensible
  {
    public OrderDeliveredNotification() {}
    
    private string _OrderID;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"OrderID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OrderID
    {
      get { return _OrderID; }
      set { _OrderID = value; }
    }
    private int _OrderStatus;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"OrderStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OrderStatus
    {
      get { return _OrderStatus; }
      set { _OrderStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OrderDeliveredConfirmation")]
  public partial class OrderDeliveredConfirmation : global::ProtoBuf.IExtensible
  {
    public OrderDeliveredConfirmation() {}
    
    private string _OrderID;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"OrderID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OrderID
    {
      get { return _OrderID; }
      set { _OrderID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IOrderEventService
    {
      Redola.Rpc.TestContracts.OrderDeliveredConfirmation OrderDelivered(Redola.Rpc.TestContracts.OrderDeliveredNotification request);
    
    }
    
    
}