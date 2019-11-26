using System;
using System.Collections.Generic;
using System.Linq;

namespace SensorGasAPI.Repositorio
{
    public class EspecialidadeProfissionalCarga
    {

        public void CargaEspecialidades()
        {
            int codigoClasseProfissional = 1;

            var classes = new ClasseProfissionalDAL().GetClasses();

            while (codigoClasseProfissional <= classes.Count)
            {
                var especialidades = RecuperarEspecialidade(codigoClasseProfissional);

                foreach (var especialidade in especialidades)
                {
                    new EspecialidadeProfissionalDAL().InsertEspecialidade(codigoClasseProfissional, especialidade);
                }

                codigoClasseProfissional += 1;

            }

        }

        public List<string> RecuperarEspecialidade(long aCodigoClasseProfissional)
        {

            switch (aCodigoClasseProfissional)
            {
                case 1:
                    List<string> especialidades01 = new List<string>();

                    especialidades01.Add("Clínica Médica");
                    especialidades01.Add("Cirurgia Geral");
                    especialidades01.Add("Cardiologia");
                    especialidades01.Add("Dermatologia");
                    especialidades01.Add("Pediatria");
                    especialidades01.Add("Ginecologia e Obstetrícia");
                    especialidades01.Add("Oftalmologia");
                    especialidades01.Add("Otorrinolaringologia");
                    especialidades01.Add("Hematalogia e Hemoterapia");
                    especialidades01.Add("Anestesiologia");
                    especialidades01.Add("Ortopedia e Traumatologia");
                    especialidades01.Add("Radiologia");
                    especialidades01.Add("Medicina Intensiva");
                    especialidades01.Add("Neurocirurugia");
                    especialidades01.Add("Infectologia");
                    especialidades01.Add("Endocrinologia");
                    especialidades01.Add("Geriatria");
                    especialidades01.Add("Radioterapia");
                    especialidades01.Add("Urologia");
                    especialidades01.Add("Endoscopia");
                    especialidades01.Add("Alergia e Imunologia");
                    especialidades01.Add("Patologia");
                    especialidades01.Add("Reumatologia");
                    especialidades01.Add("Homeopatia");
                    especialidades01.Add("Nefrologia");
                    especialidades01.Add("Cirurgia Cardiovascular");

                    return especialidades01;

                case 2:
                    List<string> especialidades02 = new List<string>();

                    especialidades02.Add("Ortondotia");
                    especialidades02.Add("Dentísica");
                    especialidades02.Add("Periodontia");
                    especialidades02.Add("Cirurgia");
                    especialidades02.Add("Endodontia");
                    especialidades02.Add("Prótese Dentária");
                    especialidades02.Add("Patologia Bucal");
                    especialidades02.Add("Odontopediatria");
                    especialidades02.Add("Odontogeriatria");
                    especialidades02.Add("Implantodontia");
                    especialidades02.Add("Estomatologia");

                    return especialidades02;

                case 3:
                    List<string> especialidades03 = new List<string>();

                    especialidades03.Add("Nutrição Clínica");
                    especialidades03.Add("Nutrição em Esportes");


                    return especialidades03;

                case 4:

                    List<string> especialidades04 = new List<string>();

                    especialidades04.Add("Psicologia Clínica");
                    especialidades04.Add("Neuropsicologia");
                    especialidades04.Add("Psicomotricidade");
                    especialidades04.Add("Psicopedagogia");
                    especialidades04.Add("Psicologia de Trânsito");
                    especialidades04.Add("Psicologia Social");

                    return especialidades04;

                case 5:

                    List<string> especialidades05 = new List<string>();

                    especialidades05.Add("Acunputura");
                    especialidades05.Add("Fisioterapia Cardiovascular");
                    especialidades05.Add("Fisioterapia Esportiva");
                    especialidades05.Add("Fisioterapia Neurofuncional ");
                    especialidades05.Add("Fisioterapia Respiratóri");
                    especialidades05.Add("Fisioterapia Traumato-Ortopédica");
                    especialidades05.Add("Osteopatia");
                    especialidades05.Add("Quiropraxia");
                    especialidades05.Add("Fisioterapia Aquática");
                    especialidades05.Add("Fisioterapia Dermato-Funcional");

                    return especialidades05;
            }

            return null;
        }

        public void InserirEspecialidadeDoProfissional()
        {
            new EspecialidadeProfissionalDAL().InsertEspecialidadeDoProfissional(1, 1);
            new EspecialidadeProfissionalDAL().InsertEspecialidadeDoProfissional(2, 3);
            new EspecialidadeProfissionalDAL().InsertEspecialidadeDoProfissional(3, 4);
            new EspecialidadeProfissionalDAL().InsertEspecialidadeDoProfissional(4, 7);
            new EspecialidadeProfissionalDAL().InsertEspecialidadeDoProfissional(5, 11);
            new EspecialidadeProfissionalDAL().InsertEspecialidadeDoProfissional(6, 14);
            new EspecialidadeProfissionalDAL().InsertEspecialidadeDoProfissional(7, 24);
            new EspecialidadeProfissionalDAL().InsertEspecialidadeDoProfissional(8, 1);
            new EspecialidadeProfissionalDAL().InsertEspecialidadeDoProfissional(9, 23);
            new EspecialidadeProfissionalDAL().InsertEspecialidadeDoProfissional(10, 16);

        }

    }

}