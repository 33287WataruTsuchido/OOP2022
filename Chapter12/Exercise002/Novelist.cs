using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

public class Novelist {
    
    [XmlElement(ElementName = "name")]
    [DataMember(Name ="name")]
    public string Name { get; set; }
    [XmlElement(ElementName = "birth")]
    [DataMember(Name = "birth")]
    public DateTime Birth { get; set; }
    [XmlElement(ElementName = "masertpieces")]
    [DataMember(Name = "masertpieces")]
    public string[] Masterpieces { get; set; }
}
