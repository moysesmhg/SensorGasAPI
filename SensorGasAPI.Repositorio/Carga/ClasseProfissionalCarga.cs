using System.Collections.Generic;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class ClasseProfissionalCarga
    {

        public void CargaClasses()
        {
            List<ClasseProfissionalDados> listaClasses = new List<ClasseProfissionalDados>();
            listaClasses.Add(new ClasseProfissionalDados() { DescricaoClasseProfissional = "Médico", ConselhoProfissional = "CRM" });
            listaClasses.Add(new ClasseProfissionalDados() { DescricaoClasseProfissional = "Odontologia", ConselhoProfissional = "CRO" });
            listaClasses.Add(new ClasseProfissionalDados() { DescricaoClasseProfissional = "Nutrição", ConselhoProfissional = "CRN" });
            listaClasses.Add(new ClasseProfissionalDados() { DescricaoClasseProfissional = "Psicologia", ConselhoProfissional = "CRP" });
            listaClasses.Add(new ClasseProfissionalDados() { DescricaoClasseProfissional = "Terapia", ConselhoProfissional = "CREFITO" });

            foreach (var item in listaClasses)
            {
                new ClasseProfissionalDAL().InsertClasse(item);
            }
        }

    }

}