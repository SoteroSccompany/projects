using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SituaçãoDeAprendizagem
{
    class ClassReflorestamento
    {
        ClassAcessoBD bd = new ClassAcessoBD();
        ClassCliente cliente = new ClassCliente();
        public int CodReflorestamento { get; set; }
        public int Ano { get; set; }
        public string Estado { get; set; }
        public int NarvoresCortadas { get; set; }
        public double VolumeM3 { get; set; }
        public int ArvoreARepor { get; set; }
        public double ArvoreAPagar { get; set; }
        public int CodUsuarioResp { get; set; }
        public int CodAdmValidação { get; set; }

        public DataTable RetTodasInfo()

        
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT codCalculo,ano,estado,numArvoresCortadas,volumeM3,CodcodUsuarioResp FROM Reflorestamento" +
                ""));

            bd.Desconectar();
            return dt;
        }

        public DataTable RetTodasInfo2()


        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Reflorestamento" +
                ""));

            bd.Desconectar();
            return dt;
        }

        public void CadastrarReflorestamento()
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("INSERT  INTO Reflorestamento   " +
                "VALUES ({0},'{1}',{2},{3},{4},{5},{6})", Ano,Estado,NarvoresCortadas,VolumeM3,"null","null", cliente.Iduser));

            bd.Desconectar();
        }
        public void CadastrarReflorestamento2()
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("INSERT  INTO Reflorestamento   " +
                "VALUES ({0},'{1}',{2},{3},{4},{5},{6})", Ano, Estado, NarvoresCortadas, VolumeM3, ArvoreAPagar,ArvoreAPagar, cliente.Iduser));

            bd.Desconectar();
        }
        public bool ContemLetras(string texto)
        {
            if (texto.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public bool ContemNumeros(string texto)
        {
            if (texto.Where(c => char.IsNumber(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public bool Verifica(string texto)
        {
            if (this.ContemNumeros(texto) && this.ContemNumeros(texto))//This para acesssar uma função de algo
                                                                       //igual da classe anterior 
            {
                //Contem Letras e Números
                return false;
            }
            else if (this.ContemLetras(texto))
            {
                //Contem somente letras
                return false;
            }
            else if (this.ContemNumeros(texto))
            {
                return true;
            }
            else
                return false;

        }

        public DataTable RetReflorePorAno(string buscaPorNome)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Reflorestamento WHERE ano" +
                " like '%{0}%'", buscaPorNome));

            bd.Desconectar();

            return dt;
        }

        public DataTable RetReflorePorEstado(string buscaPorNome)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Reflorestamento WHERE estado like '%{0}%'", buscaPorNome));

            bd.Desconectar();

            return dt;
        }

        public void EditarDados(int codCliente)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("UPDATE Reflorestamento  SET ano = {0},estado = '{1}', numArvoresCortadas = {2}, volumeM3 = {3}, arvoresARepor = {4},valorAPAgar = {5}, CodcodUsuarioResp = {6}" +
                " WHERE codCalculo = {7}",
                Ano,Estado,NarvoresCortadas,VolumeM3,"null","null",cliente.Iduser,codCliente));

            bd.Desconectar();
        }

        public bool Excluir(int idUser)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("DELETE FROM Reflorestamento WHERE codCalculo = {0}", idUser));

            bd.Desconectar();
            return true;
        }

       public void CadastrarPAg()
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("UPDATE Reflorestamento  SET  arvoresARepor = {0}, valorAPAgar = '{1}', CodcodUsuarioResp = {2}" +
                " WHERE codCalculo = {3}",
                ArvoreARepor,ArvoreAPagar,cliente.Iduser, CodReflorestamento));

            bd.Desconectar();
        }

    }
}
