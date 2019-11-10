using System.ComponentModel;

namespace SensorGasAPI.Negocio
{
    public enum ClasseProfissionalEnumerador
    {
        [System.Xml.Serialization.XmlEnum("Médico")]
        Medico = 1,
        [System.Xml.Serialization.XmlEnum("Odontologia")]
        Odontologia = 2,
        [System.Xml.Serialization.XmlEnum("Nutrição")]
        Nutricao = 3,
        [System.Xml.Serialization.XmlEnum("Farmácia")]
        Farmacia = 4,
        [System.Xml.Serialization.XmlEnum("Psicologia")]
        Psicologia = 5

    }
}
