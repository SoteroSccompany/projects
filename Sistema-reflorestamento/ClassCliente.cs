using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SituaçãoDeAprendizagem
{

    class ClassCliente
    {

        ClassAcessoBD bd = new ClassAcessoBD();
        public int Iduser { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; } // fzr
        public string Email { get; set; }//Email
        public int TipoUsuario { get; set; }
        public int CodUsuarioResp { get; set; }

        public DataTable logar()
        {

            bd.Conectar();
            //WHERE loginn like '{0}' and senha like '{1}'", Login, Senha
            //OBS: utilização do break para pauusar uma determnada ação ao chegar em um ponto desejado 
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE loginn LIKE '{0}' AND senha like '{1}' ", Login, Senha));

            bd.Desconectar();
            return dt;


        }


        public DataTable RetTodasInfo()
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario"));

            bd.Desconectar();
            return dt;
        }

        public void InseriDados()
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("INSERT INTO Usuario   " +
                "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7})", Nome, Telefone, Cpf, Email, Login, Senha, TipoUsuario, CodUsuarioResp));

            bd.Desconectar();
        }

        public void EditarDados(int codCliente)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("UPDATE Usuario  SET nome = '{0}',telefone ='{1}',cpf = '{2}',email = '{3}'," +
                "loginn = '{4}', senha ='{5}',tipoUsuario = {6} WHERE codUsuario =  {7} ",
                Nome, Telefone, Cpf, Email, Login, Senha, TipoUsuario, codCliente));

            bd.Desconectar();
        }

        public DataTable RetclientePorCpf(string buscaPorNome)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE cpf like '%{0}%'", buscaPorNome));

            bd.Desconectar();

            return dt;
        }

        public DataTable RetclientePorNome(string buscaPorNome)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE nome like '%{0}%'", buscaPorNome));

            bd.Desconectar();

            return dt;
        }

        public bool Excluir(int idUser)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("DELETE FROM Usuario WHERE codUsuario = {0}", idUser));

            bd.Desconectar();
            return true;
        }

        public bool VerificarCpfBD()
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT cpf FROM Usuario WHERE cpf like '%{0}%'", Cpf));

            bd.Desconectar();

            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool VerificarEmailBd()
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT email FROM Usuario WHERE email like '%{0}%'", Email));

            bd.Desconectar();
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
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
            if (this.ContemLetras(texto) && this.ContemNumeros(texto))//This para acesssar uma função de algo
                //igual da classe anterior 
            {
                //Contem Letras e Números
                return true;
            }
            else 
            {
                //Contem somente letras
                return false;
                
            }

        }

        public bool VerificarEmailBdEmail(string email)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE email like '%{0}%'", email));

            bd.Desconectar();
            if (dt.Rows.Count > 0)
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PegarSenha(string email)
        {

            bd.Conectar();
            //WHERE loginn like '{0}' and senha like '{1}'", Login, Senha
            //OBS: utilização do break para pauusar uma determnada ação ao chegar em um ponto desejado 
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE email LIKE '{0}'",email));
            bd.Desconectar();
            
        }

    }
    }

