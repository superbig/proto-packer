// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: DataPiece.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WS.Data {

  /// <summary>Holder for reflection information generated from DataPiece.proto</summary>
  public static partial class DataPieceReflection {

    #region Descriptor
    /// <summary>File descriptor for DataPiece.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataPieceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9EYXRhUGllY2UucHJvdG8SB1dTLkRhdGEiSgoJRGF0YVBpZWNlEgoKAmlk",
            "GAEgASgFEhAKCHBvc2l0aW9uGAIgASgJEg8KB2xldmVsSWQYAyABKAUSDgoG",
            "bGF5b3V0GAQgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WS.Data.DataPiece), global::WS.Data.DataPiece.Parser, new[]{ "Id", "Position", "LevelId", "Layout" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DataPiece : pb::IMessage<DataPiece> {
    private static readonly pb::MessageParser<DataPiece> _parser = new pb::MessageParser<DataPiece>(() => new DataPiece());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DataPiece> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WS.Data.DataPieceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataPiece() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataPiece(DataPiece other) : this() {
      id_ = other.id_;
      position_ = other.position_;
      levelId_ = other.levelId_;
      layout_ = other.layout_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataPiece Clone() {
      return new DataPiece(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    /// <summary>
    ///唯一标识
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 2;
    private string position_ = "";
    /// <summary>
    ///初始坐标
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Position {
      get { return position_; }
      set {
        position_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "levelId" field.</summary>
    public const int LevelIdFieldNumber = 3;
    private int levelId_;
    /// <summary>
    ///所属关卡
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "layout" field.</summary>
    public const int LayoutFieldNumber = 4;
    private string layout_ = "";
    /// <summary>
    ///布局信息
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Layout {
      get { return layout_; }
      set {
        layout_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DataPiece);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DataPiece other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Position != other.Position) return false;
      if (LevelId != other.LevelId) return false;
      if (Layout != other.Layout) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Position.Length != 0) hash ^= Position.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (Layout.Length != 0) hash ^= Layout.GetHashCode();
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
      if (Position.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Position);
      }
      if (LevelId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(LevelId);
      }
      if (Layout.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Layout);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Position.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Position);
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LevelId);
      }
      if (Layout.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Layout);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DataPiece other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Position.Length != 0) {
        Position = other.Position;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.Layout.Length != 0) {
        Layout = other.Layout;
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
            Position = input.ReadString();
            break;
          }
          case 24: {
            LevelId = input.ReadInt32();
            break;
          }
          case 34: {
            Layout = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
