using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroPessoa.VO; //INCLUIR BIBLIOTECA VO
using Npgsql; //INCLUIR BIBLIOTECA POSTGRES

namespace CadastroPessoa.DAO
{
    class PessoaDAO : BaseDAO
    {
        public static List<FisicaVO> listaCadastro;

        public FisicaVO pessoaFisica { get; set; }

        public PessoaDAO()
        {
            if(listaCadastro == null)
            {
                listaCadastro = new List<FisicaVO>();
            }
        }

        public void create() //INSERT
        {
            this.sql = "INSERT INTO pessoa (id, cpf, nome, endereco, telefone) VALUES (@id ,@cpf, @nome, @endereco, @telefone)";
            comando.CommandText = this.sql;
            this.parametros.Add(new NpgsqlParameter("@id", pessoaFisica.id));
            this.parametros.Add(new NpgsqlParameter("@cpf", pessoaFisica.cpf));
            this.parametros.Add(new NpgsqlParameter("@nome", pessoaFisica.nome));
            this.parametros.Add(new NpgsqlParameter("@endereco", pessoaFisica.endereco));
            this.parametros.Add(new NpgsqlParameter("@telefone", pessoaFisica.telefone));
            execute();
        }

        public void update() //UPDATE
        {
            this.sql = "UPDATE pessoa SET nome=@nome, endereco=@endereco, telefone=@telefone WHERE cpf=@cpf"; //ou cpf ou id
            comando.CommandText = this.sql;
            parametros.Add(new NpgsqlParameter("@cpf", pessoaFisica.cpf));
            parametros.Add(new NpgsqlParameter("@nome", pessoaFisica.nome));
            parametros.Add(new NpgsqlParameter("@endereco", pessoaFisica.endereco));
            parametros.Add(new NpgsqlParameter("@telefone", pessoaFisica.telefone));
            execute();
        }

        public void delete() //DELETE
        {
            this.sql = "DELETE FROM pessoa WHERE cpf=@cpf";
            comando.CommandText = this.sql;
            parametros.Add(new NpgsqlParameter("@cpf", pessoaFisica.cpf));
            execute();
        }

        public List<FisicaVO> list() //SELECT
        {
            this.sql = "SELECT * FROM pessoa";
            listaCadastro = new List<FisicaVO>();

            using (var dr = executeReader())
            {
                while (dr.Read())
                {
                    pessoaFisica = new FisicaVO();
                    pessoaFisica.id = Convert.ToInt32(dr["id"]);
                    pessoaFisica.cpf = dr["cpf"] != DBNull.Value ? dr["cpf"].ToString() : "";
                    pessoaFisica.nome = dr["nome"] != DBNull.Value ? dr["nome"].ToString() : "";
                    pessoaFisica.endereco = dr["endereco"] != DBNull.Value ? dr["endereco"].ToString() : "";
                    pessoaFisica.telefone = dr["telefone"] != DBNull.Value ? dr["telefone"].ToString() : "";

                    listaCadastro.Add(pessoaFisica);
                }
               
            }
            return listaCadastro;
        }

    }
}
