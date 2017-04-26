// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Entity.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Org.Dragonet.Cloudland.Net.Protocol {

  /// <summary>Holder for reflection information generated from Entity.proto</summary>
  public static partial class EntityReflection {

    #region Descriptor
    /// <summary>File descriptor for Entity.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxFbnRpdHkucHJvdG8SI29yZy5kcmFnb25ldC5jbG91ZGxhbmQubmV0LnBy",
            "b3RvY29sGg5NZXRhZGF0YS5wcm90byLzAQoWU2VydmVyQWRkRW50aXR5TWVz",
            "c2FnZRIQCghlbnRpdHlJZBgBIAEoBBJDCgplbnRpdHlUeXBlGAIgASgOMi8u",
            "b3JnLmRyYWdvbmV0LmNsb3VkbGFuZC5uZXQucHJvdG9jb2wuRW50aXR5VHlw",
            "ZRIJCgF4GAMgASgBEgkKAXkYBCABKAESCQoBehgFIAEoARILCgN5YXcYBiAB",
            "KAISDQoFcGl0Y2gYByABKAISRQoEbWV0YRgIIAEoCzI3Lm9yZy5kcmFnb25l",
            "dC5jbG91ZGxhbmQubmV0LnByb3RvY29sLlNlcmlhbGl6ZWRNZXRhZGF0YSLv",
            "AQoZU2VydmVyRW50aXR5VXBkYXRlTWVzc2FnZRIQCghlbnRpdHlJZBgBIAEo",
            "BBIUCgxmbGFnUG9zaXRpb24YAiABKAgSCQoBeBgDIAEoARIJCgF5GAQgASgB",
            "EgkKAXoYBSABKAESFAoMZmxhZ1JvdGF0aW9uGAYgASgIEgsKA3lhdxgHIAEo",
            "AhINCgVwaXRjaBgIIAEoAhIQCghmbGFnTWV0YRgJIAEoCBJFCgRtZXRhGAog",
            "ASgLMjcub3JnLmRyYWdvbmV0LmNsb3VkbGFuZC5uZXQucHJvdG9jb2wuU2Vy",
            "aWFsaXplZE1ldGFkYXRhIi0KGVNlcnZlclJlbW92ZUVudGl0eU1lc3NhZ2US",
            "EAoIZW50aXR5SWQYASABKAQiHAoaU2VydmVyQ2xlYXJFbnRpdGllc01lc3Nh",
            "Z2UqIgoKRW50aXR5VHlwZRIKCgZQTEFZRVIQABIICgRJVEVNEAFiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Org.Dragonet.Cloudland.Net.Protocol.MetadataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Org.Dragonet.Cloudland.Net.Protocol.EntityType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ServerAddEntityMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ServerAddEntityMessage.Parser, new[]{ "EntityId", "EntityType", "X", "Y", "Z", "Yaw", "Pitch", "Meta" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ServerEntityUpdateMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ServerEntityUpdateMessage.Parser, new[]{ "EntityId", "FlagPosition", "X", "Y", "Z", "FlagRotation", "Yaw", "Pitch", "FlagMeta", "Meta" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ServerRemoveEntityMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ServerRemoveEntityMessage.Parser, new[]{ "EntityId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ServerClearEntitiesMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ServerClearEntitiesMessage.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum EntityType {
    [pbr::OriginalName("PLAYER")] Player = 0,
    [pbr::OriginalName("ITEM")] Item = 1,
  }

  #endregion

  #region Messages
  public sealed partial class ServerAddEntityMessage : pb::IMessage<ServerAddEntityMessage> {
    private static readonly pb::MessageParser<ServerAddEntityMessage> _parser = new pb::MessageParser<ServerAddEntityMessage>(() => new ServerAddEntityMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerAddEntityMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.EntityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerAddEntityMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerAddEntityMessage(ServerAddEntityMessage other) : this() {
      entityId_ = other.entityId_;
      entityType_ = other.entityType_;
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      yaw_ = other.yaw_;
      pitch_ = other.pitch_;
      Meta = other.meta_ != null ? other.Meta.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerAddEntityMessage Clone() {
      return new ServerAddEntityMessage(this);
    }

    /// <summary>Field number for the "entityId" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private ulong entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "entityType" field.</summary>
    public const int EntityTypeFieldNumber = 2;
    private global::Org.Dragonet.Cloudland.Net.Protocol.EntityType entityType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Org.Dragonet.Cloudland.Net.Protocol.EntityType EntityType {
      get { return entityType_; }
      set {
        entityType_ = value;
      }
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 3;
    private double x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 4;
    private double y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 5;
    private double z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    /// <summary>Field number for the "yaw" field.</summary>
    public const int YawFieldNumber = 6;
    private float yaw_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Yaw {
      get { return yaw_; }
      set {
        yaw_ = value;
      }
    }

    /// <summary>Field number for the "pitch" field.</summary>
    public const int PitchFieldNumber = 7;
    private float pitch_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Pitch {
      get { return pitch_; }
      set {
        pitch_ = value;
      }
    }

    /// <summary>Field number for the "meta" field.</summary>
    public const int MetaFieldNumber = 8;
    private global::Org.Dragonet.Cloudland.Net.Protocol.SerializedMetadata meta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Org.Dragonet.Cloudland.Net.Protocol.SerializedMetadata Meta {
      get { return meta_; }
      set {
        meta_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerAddEntityMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerAddEntityMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (EntityType != other.EntityType) return false;
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Z != other.Z) return false;
      if (Yaw != other.Yaw) return false;
      if (Pitch != other.Pitch) return false;
      if (!object.Equals(Meta, other.Meta)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0UL) hash ^= EntityId.GetHashCode();
      if (EntityType != 0) hash ^= EntityType.GetHashCode();
      if (X != 0D) hash ^= X.GetHashCode();
      if (Y != 0D) hash ^= Y.GetHashCode();
      if (Z != 0D) hash ^= Z.GetHashCode();
      if (Yaw != 0F) hash ^= Yaw.GetHashCode();
      if (Pitch != 0F) hash ^= Pitch.GetHashCode();
      if (meta_ != null) hash ^= Meta.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EntityId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(EntityId);
      }
      if (EntityType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) EntityType);
      }
      if (X != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(X);
      }
      if (Y != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Y);
      }
      if (Z != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Z);
      }
      if (Yaw != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(Yaw);
      }
      if (Pitch != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(Pitch);
      }
      if (meta_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Meta);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EntityId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(EntityId);
      }
      if (EntityType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EntityType);
      }
      if (X != 0D) {
        size += 1 + 8;
      }
      if (Y != 0D) {
        size += 1 + 8;
      }
      if (Z != 0D) {
        size += 1 + 8;
      }
      if (Yaw != 0F) {
        size += 1 + 4;
      }
      if (Pitch != 0F) {
        size += 1 + 4;
      }
      if (meta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Meta);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerAddEntityMessage other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0UL) {
        EntityId = other.EntityId;
      }
      if (other.EntityType != 0) {
        EntityType = other.EntityType;
      }
      if (other.X != 0D) {
        X = other.X;
      }
      if (other.Y != 0D) {
        Y = other.Y;
      }
      if (other.Z != 0D) {
        Z = other.Z;
      }
      if (other.Yaw != 0F) {
        Yaw = other.Yaw;
      }
      if (other.Pitch != 0F) {
        Pitch = other.Pitch;
      }
      if (other.meta_ != null) {
        if (meta_ == null) {
          meta_ = new global::Org.Dragonet.Cloudland.Net.Protocol.SerializedMetadata();
        }
        Meta.MergeFrom(other.Meta);
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
            EntityId = input.ReadUInt64();
            break;
          }
          case 16: {
            entityType_ = (global::Org.Dragonet.Cloudland.Net.Protocol.EntityType) input.ReadEnum();
            break;
          }
          case 25: {
            X = input.ReadDouble();
            break;
          }
          case 33: {
            Y = input.ReadDouble();
            break;
          }
          case 41: {
            Z = input.ReadDouble();
            break;
          }
          case 53: {
            Yaw = input.ReadFloat();
            break;
          }
          case 61: {
            Pitch = input.ReadFloat();
            break;
          }
          case 66: {
            if (meta_ == null) {
              meta_ = new global::Org.Dragonet.Cloudland.Net.Protocol.SerializedMetadata();
            }
            input.ReadMessage(meta_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ServerEntityUpdateMessage : pb::IMessage<ServerEntityUpdateMessage> {
    private static readonly pb::MessageParser<ServerEntityUpdateMessage> _parser = new pb::MessageParser<ServerEntityUpdateMessage>(() => new ServerEntityUpdateMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerEntityUpdateMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.EntityReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerEntityUpdateMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerEntityUpdateMessage(ServerEntityUpdateMessage other) : this() {
      entityId_ = other.entityId_;
      flagPosition_ = other.flagPosition_;
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      flagRotation_ = other.flagRotation_;
      yaw_ = other.yaw_;
      pitch_ = other.pitch_;
      flagMeta_ = other.flagMeta_;
      Meta = other.meta_ != null ? other.Meta.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerEntityUpdateMessage Clone() {
      return new ServerEntityUpdateMessage(this);
    }

    /// <summary>Field number for the "entityId" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private ulong entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "flagPosition" field.</summary>
    public const int FlagPositionFieldNumber = 2;
    private bool flagPosition_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool FlagPosition {
      get { return flagPosition_; }
      set {
        flagPosition_ = value;
      }
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 3;
    private double x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 4;
    private double y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 5;
    private double z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    /// <summary>Field number for the "flagRotation" field.</summary>
    public const int FlagRotationFieldNumber = 6;
    private bool flagRotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool FlagRotation {
      get { return flagRotation_; }
      set {
        flagRotation_ = value;
      }
    }

    /// <summary>Field number for the "yaw" field.</summary>
    public const int YawFieldNumber = 7;
    private float yaw_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Yaw {
      get { return yaw_; }
      set {
        yaw_ = value;
      }
    }

    /// <summary>Field number for the "pitch" field.</summary>
    public const int PitchFieldNumber = 8;
    private float pitch_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Pitch {
      get { return pitch_; }
      set {
        pitch_ = value;
      }
    }

    /// <summary>Field number for the "flagMeta" field.</summary>
    public const int FlagMetaFieldNumber = 9;
    private bool flagMeta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool FlagMeta {
      get { return flagMeta_; }
      set {
        flagMeta_ = value;
      }
    }

    /// <summary>Field number for the "meta" field.</summary>
    public const int MetaFieldNumber = 10;
    private global::Org.Dragonet.Cloudland.Net.Protocol.SerializedMetadata meta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Org.Dragonet.Cloudland.Net.Protocol.SerializedMetadata Meta {
      get { return meta_; }
      set {
        meta_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerEntityUpdateMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerEntityUpdateMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (FlagPosition != other.FlagPosition) return false;
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Z != other.Z) return false;
      if (FlagRotation != other.FlagRotation) return false;
      if (Yaw != other.Yaw) return false;
      if (Pitch != other.Pitch) return false;
      if (FlagMeta != other.FlagMeta) return false;
      if (!object.Equals(Meta, other.Meta)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0UL) hash ^= EntityId.GetHashCode();
      if (FlagPosition != false) hash ^= FlagPosition.GetHashCode();
      if (X != 0D) hash ^= X.GetHashCode();
      if (Y != 0D) hash ^= Y.GetHashCode();
      if (Z != 0D) hash ^= Z.GetHashCode();
      if (FlagRotation != false) hash ^= FlagRotation.GetHashCode();
      if (Yaw != 0F) hash ^= Yaw.GetHashCode();
      if (Pitch != 0F) hash ^= Pitch.GetHashCode();
      if (FlagMeta != false) hash ^= FlagMeta.GetHashCode();
      if (meta_ != null) hash ^= Meta.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EntityId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(EntityId);
      }
      if (FlagPosition != false) {
        output.WriteRawTag(16);
        output.WriteBool(FlagPosition);
      }
      if (X != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(X);
      }
      if (Y != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Y);
      }
      if (Z != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Z);
      }
      if (FlagRotation != false) {
        output.WriteRawTag(48);
        output.WriteBool(FlagRotation);
      }
      if (Yaw != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(Yaw);
      }
      if (Pitch != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(Pitch);
      }
      if (FlagMeta != false) {
        output.WriteRawTag(72);
        output.WriteBool(FlagMeta);
      }
      if (meta_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Meta);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EntityId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(EntityId);
      }
      if (FlagPosition != false) {
        size += 1 + 1;
      }
      if (X != 0D) {
        size += 1 + 8;
      }
      if (Y != 0D) {
        size += 1 + 8;
      }
      if (Z != 0D) {
        size += 1 + 8;
      }
      if (FlagRotation != false) {
        size += 1 + 1;
      }
      if (Yaw != 0F) {
        size += 1 + 4;
      }
      if (Pitch != 0F) {
        size += 1 + 4;
      }
      if (FlagMeta != false) {
        size += 1 + 1;
      }
      if (meta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Meta);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerEntityUpdateMessage other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0UL) {
        EntityId = other.EntityId;
      }
      if (other.FlagPosition != false) {
        FlagPosition = other.FlagPosition;
      }
      if (other.X != 0D) {
        X = other.X;
      }
      if (other.Y != 0D) {
        Y = other.Y;
      }
      if (other.Z != 0D) {
        Z = other.Z;
      }
      if (other.FlagRotation != false) {
        FlagRotation = other.FlagRotation;
      }
      if (other.Yaw != 0F) {
        Yaw = other.Yaw;
      }
      if (other.Pitch != 0F) {
        Pitch = other.Pitch;
      }
      if (other.FlagMeta != false) {
        FlagMeta = other.FlagMeta;
      }
      if (other.meta_ != null) {
        if (meta_ == null) {
          meta_ = new global::Org.Dragonet.Cloudland.Net.Protocol.SerializedMetadata();
        }
        Meta.MergeFrom(other.Meta);
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
            EntityId = input.ReadUInt64();
            break;
          }
          case 16: {
            FlagPosition = input.ReadBool();
            break;
          }
          case 25: {
            X = input.ReadDouble();
            break;
          }
          case 33: {
            Y = input.ReadDouble();
            break;
          }
          case 41: {
            Z = input.ReadDouble();
            break;
          }
          case 48: {
            FlagRotation = input.ReadBool();
            break;
          }
          case 61: {
            Yaw = input.ReadFloat();
            break;
          }
          case 69: {
            Pitch = input.ReadFloat();
            break;
          }
          case 72: {
            FlagMeta = input.ReadBool();
            break;
          }
          case 82: {
            if (meta_ == null) {
              meta_ = new global::Org.Dragonet.Cloudland.Net.Protocol.SerializedMetadata();
            }
            input.ReadMessage(meta_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ServerRemoveEntityMessage : pb::IMessage<ServerRemoveEntityMessage> {
    private static readonly pb::MessageParser<ServerRemoveEntityMessage> _parser = new pb::MessageParser<ServerRemoveEntityMessage>(() => new ServerRemoveEntityMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerRemoveEntityMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.EntityReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerRemoveEntityMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerRemoveEntityMessage(ServerRemoveEntityMessage other) : this() {
      entityId_ = other.entityId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerRemoveEntityMessage Clone() {
      return new ServerRemoveEntityMessage(this);
    }

    /// <summary>Field number for the "entityId" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private ulong entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerRemoveEntityMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerRemoveEntityMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0UL) hash ^= EntityId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EntityId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(EntityId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EntityId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(EntityId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerRemoveEntityMessage other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0UL) {
        EntityId = other.EntityId;
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
            EntityId = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ServerClearEntitiesMessage : pb::IMessage<ServerClearEntitiesMessage> {
    private static readonly pb::MessageParser<ServerClearEntitiesMessage> _parser = new pb::MessageParser<ServerClearEntitiesMessage>(() => new ServerClearEntitiesMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerClearEntitiesMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.EntityReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerClearEntitiesMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerClearEntitiesMessage(ServerClearEntitiesMessage other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerClearEntitiesMessage Clone() {
      return new ServerClearEntitiesMessage(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerClearEntitiesMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerClearEntitiesMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerClearEntitiesMessage other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
