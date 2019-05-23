// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: DataPayment.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WS.Data {

  /// <summary>Holder for reflection information generated from DataPayment.proto</summary>
  public static partial class DataPaymentReflection {

    #region Descriptor
    /// <summary>File descriptor for DataPayment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataPaymentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFEYXRhUGF5bWVudC5wcm90bxIHV1MuRGF0YSJ2CgtEYXRhUGF5bWVudBIK",
            "CgJpZBgBIAEoBRIUCgxkZWZpbml0aW9uSWQYAiABKAkSEAoIYWRkTW9uZXkY",
            "AyABKAUSEAoIdG9vbHNUaXAYBCABKAUSEwoLdG9vbHNQdXp6bGUYBSABKAUS",
            "DAoEY29zdBgGIAEoAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WS.Data.DataPayment), global::WS.Data.DataPayment.Parser, new[]{ "Id", "DefinitionId", "AddMoney", "ToolsTip", "ToolsPuzzle", "Cost" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DataPayment : pb::IMessage<DataPayment> {
    private static readonly pb::MessageParser<DataPayment> _parser = new pb::MessageParser<DataPayment>(() => new DataPayment());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DataPayment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WS.Data.DataPaymentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataPayment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataPayment(DataPayment other) : this() {
      id_ = other.id_;
      definitionId_ = other.definitionId_;
      addMoney_ = other.addMoney_;
      toolsTip_ = other.toolsTip_;
      toolsPuzzle_ = other.toolsPuzzle_;
      cost_ = other.cost_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataPayment Clone() {
      return new DataPayment(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    /// <summary>
    ///唯一表示
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "definitionId" field.</summary>
    public const int DefinitionIdFieldNumber = 2;
    private string definitionId_ = "";
    /// <summary>
    ///SDK中的ID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DefinitionId {
      get { return definitionId_; }
      set {
        definitionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "addMoney" field.</summary>
    public const int AddMoneyFieldNumber = 3;
    private int addMoney_;
    /// <summary>
    ///增加的金币
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AddMoney {
      get { return addMoney_; }
      set {
        addMoney_ = value;
      }
    }

    /// <summary>Field number for the "toolsTip" field.</summary>
    public const int ToolsTipFieldNumber = 4;
    private int toolsTip_;
    /// <summary>
    ///增加的提示道具
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ToolsTip {
      get { return toolsTip_; }
      set {
        toolsTip_ = value;
      }
    }

    /// <summary>Field number for the "toolsPuzzle" field.</summary>
    public const int ToolsPuzzleFieldNumber = 5;
    private int toolsPuzzle_;
    /// <summary>
    ///增加的合并道具
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ToolsPuzzle {
      get { return toolsPuzzle_; }
      set {
        toolsPuzzle_ = value;
      }
    }

    /// <summary>Field number for the "cost" field.</summary>
    public const int CostFieldNumber = 6;
    private float cost_;
    /// <summary>
    ///金额
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Cost {
      get { return cost_; }
      set {
        cost_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DataPayment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DataPayment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (DefinitionId != other.DefinitionId) return false;
      if (AddMoney != other.AddMoney) return false;
      if (ToolsTip != other.ToolsTip) return false;
      if (ToolsPuzzle != other.ToolsPuzzle) return false;
      if (Cost != other.Cost) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (DefinitionId.Length != 0) hash ^= DefinitionId.GetHashCode();
      if (AddMoney != 0) hash ^= AddMoney.GetHashCode();
      if (ToolsTip != 0) hash ^= ToolsTip.GetHashCode();
      if (ToolsPuzzle != 0) hash ^= ToolsPuzzle.GetHashCode();
      if (Cost != 0F) hash ^= Cost.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (DefinitionId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DefinitionId);
      }
      if (AddMoney != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(AddMoney);
      }
      if (ToolsTip != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ToolsTip);
      }
      if (ToolsPuzzle != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(ToolsPuzzle);
      }
      if (Cost != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(Cost);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (DefinitionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DefinitionId);
      }
      if (AddMoney != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AddMoney);
      }
      if (ToolsTip != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ToolsTip);
      }
      if (ToolsPuzzle != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ToolsPuzzle);
      }
      if (Cost != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DataPayment other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.DefinitionId.Length != 0) {
        DefinitionId = other.DefinitionId;
      }
      if (other.AddMoney != 0) {
        AddMoney = other.AddMoney;
      }
      if (other.ToolsTip != 0) {
        ToolsTip = other.ToolsTip;
      }
      if (other.ToolsPuzzle != 0) {
        ToolsPuzzle = other.ToolsPuzzle;
      }
      if (other.Cost != 0F) {
        Cost = other.Cost;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            DefinitionId = input.ReadString();
            break;
          }
          case 24: {
            AddMoney = input.ReadInt32();
            break;
          }
          case 32: {
            ToolsTip = input.ReadInt32();
            break;
          }
          case 40: {
            ToolsPuzzle = input.ReadInt32();
            break;
          }
          case 53: {
            Cost = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code