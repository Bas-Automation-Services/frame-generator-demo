using System.Collections.Generic;
using System.Xml.Serialization;

namespace FrameStiffener.Core.Shared.Assembly.FG;

[XmlRoot(ElementName = "FrameMemberDefinition")]
public class FrameMemberDefinition
{
    [XmlAttribute(AttributeName = "Standard")]
    public string Standard { get; set; }
    [XmlAttribute(AttributeName = "Type")]
    public string Type { get; set; }
    [XmlAttribute(AttributeName = "OffsetX")]
    public double OffsetX { get; set; }
    [XmlAttribute(AttributeName = "OffsetY")]
    public double OffsetY { get; set; }
    [XmlAttribute(AttributeName = "Angle")]
    public double Angle { get; set; }
    [XmlAttribute(AttributeName = "IsFlipped")]
    public int IsFlipped { get; set; }
    [XmlAttribute(AttributeName = "InsertPoint")]
    public int InsertPoint { get; set; }
    [XmlAttribute(AttributeName = "AngleString")]
    public string AngleString { get; set; }
    [XmlAttribute(AttributeName = "OffsetXString")]
    public string OffsetXString { get; set; }
    [XmlAttribute(AttributeName = "OffsetYString")]
    public string OffsetYString { get; set; }
    [XmlAttribute(AttributeName = "RenderStyleInternalName")]
    public string RenderStyleInternalName { get; set; }
    [XmlAttribute(AttributeName = "MaterialInternalName")]
    public string MaterialInternalName { get; set; }
    [XmlAttribute(AttributeName = "MonikerForNewContent")]
    public string MonikerForNewContent { get; set; }
    [XmlAttribute(AttributeName = "MonikerForCC")]
    public string MonikerForCC { get; set; }
    [XmlAttribute(AttributeName = "RotateAroundSelectedPoint")]
    public bool RotateAroundSelectedPoint { get; set; }
}

[XmlRoot(ElementName = "AxisXVector")]
public class Vector
{
    [XmlAttribute(AttributeName = "X")]
    public double X { get; set; }
    [XmlAttribute(AttributeName = "Y")]
    public double Y { get; set; }
    [XmlAttribute(AttributeName = "Z")]
    public double Z { get; set; }
}

[XmlRoot(ElementName = "Orientation")]
public class Orientation
{
    [XmlElement(ElementName = "AxisXVector")]
    public Vector AxisXVector { get; set; }
}

[XmlRoot(ElementName = "FrameMemberData")]
public class FrameMemberData
{
    [XmlElement(ElementName = "FrameMemberDefinition")]
    public FrameMemberDefinition FrameMemberDefinition { get; set; }
    [XmlElement(ElementName = "Orientation")]
    public Orientation Orientation { get; set; }
}

[XmlRoot(ElementName = "Path")]
public class Path
{
    [XmlElement(ElementName = "FrameMemberData")]
    public FrameMemberData FrameMemberData { get; set; }
    [XmlAttribute(AttributeName = "PathID")]
    public string PathID { get; set; }
    [XmlAttribute(AttributeName = "FrameMemberID")]
    public string FrameMemberID { get; set; }
}

[XmlRoot(ElementName = "Skeleton")]
public class Skeleton
{
    [XmlElement(ElementName = "Path")]
    public List<Path> Paths { get; set; }
    [XmlAttribute(AttributeName = "SkeletonID")]
    public string SkeletonID { get; set; }
}

[XmlRoot(ElementName = "FrameStructure")]
public class FrameStructure
{
    [XmlElement(ElementName = "Skeleton")]
    public Skeleton Skeleton { get; set; }
}

[XmlRoot(ElementName = "ReferenceKey")]
public class ReferenceKey
{
    [XmlAttribute(AttributeName = "ContextDocumentRelativeLevel")]
    public string ContextDocumentRelativeLevel { get; set; }
    [XmlAttribute(AttributeName = "ContextDocumentInternalName")]
    public string ContextDocumentInternalName { get; set; }
    [XmlAttribute(AttributeName = "Context")]
    public string Context { get; set; }
    [XmlText]
    public string Text { get; set; }
}

[XmlRoot(ElementName = "ProjEntity")]
public class ProjEntity
{
    [XmlAttribute(AttributeName = "Id")]
    public string Id { get; set; }
}

[XmlRoot(ElementName = "Segment")]
public class Segment
{
    [XmlElement(ElementName = "SrcEntity")]
    public SrcEntity SrcEntity { get; set; }
    [XmlElement(ElementName = "ProjEntity")]
    public ProjEntity ProjEntity { get; set; }
    [XmlAttribute(AttributeName = "Type")]
    public int Type { get; set; }
}

[XmlRoot(ElementName = "Path")]
public class SkeletonPath
{
    [XmlElement(ElementName = "Segment")]
    public Segment Segment { get; set; }
    [XmlAttribute(AttributeName = "PathID")]
    public string PathID { get; set; }
    [XmlAttribute(AttributeName = "IsApiStartPt")]
    public bool IsApiStartPt { get; set; }
    [XmlAttribute(AttributeName = "ProjEntitySerializerType")]
    public int ProjEntitySerializerType { get; set; }
    [XmlAttribute(AttributeName = "SrcEntitySerializerType")]
    public int SrcEntitySerializerType { get; set; }
}

[XmlRoot(ElementName = "Paths")]
public class Paths
{
    [XmlElement(ElementName = "Path")]
    public List<SkeletonPath> Path { get; set; }
}

[XmlRoot(ElementName = "SrcEntity")]
public class SrcEntity
{
    [XmlElement(ElementName = "ReferenceKey")]
    public ReferenceKey ReferenceKey { get; set; }
    [XmlElement(ElementName = "StartPoint")]
    public StartPoint StartPoint { get; set; }
    [XmlElement(ElementName = "EndPoint")]
    public EndPoint EndPoint { get; set; }
}

[XmlRoot(ElementName = "StartPoint")]
public class StartPoint
{
    [XmlElement(ElementName = "ReferenceKey")]
    public ReferenceKey ReferenceKey { get; set; }
}

[XmlRoot(ElementName = "EndPoint")]
public class EndPoint
{
    [XmlElement(ElementName = "ReferenceKey")]
    public ReferenceKey ReferenceKey { get; set; }
}

[XmlRoot(ElementName = "FrameMember1")]
public class FrameMember1
{
    [XmlAttribute(AttributeName = "ID")]
    public string ID { get; set; }
    [XmlAttribute(AttributeName = "PickEnd")]
    public int PickEnd { get; set; }
    [XmlAttribute(AttributeName = "IsDeleted")]
    public bool IsDeleted { get; set; }
    [XmlAttribute(AttributeName = "NotchProfileType")]
    public string NotchProfileType { get; set; }
    [XmlAttribute(AttributeName = "PerpendicularCut")]
    public string PerpendicularCut { get; set; }
    [XmlAttribute(AttributeName = "ExtendToolLength")]
    public string ExtendToolLength { get; set; }
}

[XmlRoot(ElementName = "FrameMember2")]
public class FrameMember2
{
    [XmlAttribute(AttributeName = "ID")]
    public string ID { get; set; }
    [XmlAttribute(AttributeName = "PickEnd")]
    public int PickEnd { get; set; }
    [XmlAttribute(AttributeName = "IsDeleted")]
    public bool IsDeleted { get; set; }
}

[XmlRoot(ElementName = "EndTreatment")]
public class EndTreatment
{
    [XmlElement(ElementName = "FrameMember1")]
    public FrameMember1 FrameMember1 { get; set; }
    [XmlElement(ElementName = "FrameMember2")]
    public FrameMember2 FrameMember2 { get; set; }
    [XmlElement(ElementName = "WhichType")]
    public int WhichType { get; set; }
    [XmlElement(ElementName = "Offset")]
    public double Offset { get; set; }
    [XmlElement(ElementName = "CutType")]
    public string CutType { get; set; }
    [XmlAttribute(AttributeName = "ID")]
    public string ID { get; set; }
    [XmlAttribute(AttributeName = "Type")]
    public string Type { get; set; }
    [XmlAttribute(AttributeName = "Index")]
    public int Index { get; set; }
    [XmlElement(ElementName = "FrameMember")]
    public FrameMember FrameMember { get; set; }
    [XmlElement(ElementName = "LengthenType")]
    public int LengthenType { get; set; }
    [XmlElement(ElementName = "Offset2")]
    public double Offset2 { get; set; }
    [XmlElement(ElementName = "Offsets")]
    public Offsets Offsets { get; set; }
    [XmlElement(ElementName = "CutPlane")]
    public CutPlane CutPlane { get; set; }
}

[XmlRoot(ElementName = "FrameMember")]
public class FrameMember
{
    [XmlAttribute(AttributeName = "ID")]
    public string ID { get; set; }
    [XmlAttribute(AttributeName = "PickEnd")]
    public int PickEnd { get; set; }
    [XmlAttribute(AttributeName = "IsDeleted")]
    public bool IsDeleted { get; set; }
    [XmlAttribute(AttributeName = "Trim")]
    public string Trim { get; set; }
}

[XmlRoot(ElementName = "Offsets")]
public class Offsets
{
    [XmlAttribute(AttributeName = "Count")]
    public int Count { get; set; }
    [XmlAttribute(AttributeName = "Value1")]
    public double Value1 { get; set; }
}

[XmlRoot(ElementName = "CutPlane")]
public class CutPlane
{
    [XmlElement(ElementName = "ReferenceKey")]
    public ReferenceKey ReferenceKey { get; set; }
    [XmlAttribute(AttributeName = "IsPlaneFromFrameMember")]
    public bool IsPlaneFromFrameMember { get; set; }
    [XmlAttribute(AttributeName = "FrameMember")]
    public string FrameMemberID { get; set; }
}

[XmlRoot(ElementName = "EndTreatments")]
public class EndTreatments
{
    [XmlElement(ElementName = "EndTreatment")]
    public List<EndTreatment> EndTreatment { get; set; }
    [XmlAttribute(AttributeName = "MaxIndex")]
    public string MaxIndex { get; set; }
}