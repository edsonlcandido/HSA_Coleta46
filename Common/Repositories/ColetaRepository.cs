using Common.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class ColetaRepository : IColetaRepository
    {
        private readonly string CONNECTION_STRING = @"Data Source=HSA_Coleta.db;";
        public int adicionar(ColetaModel coletaModel)
        {
            SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING);
            SQLiteCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = @"INSERT INTO coleta (
                                            dataInclusao,
                                            solicitante,
                                            setor,
                                            CC_Projeto,
                                            dataNecessaria,
                                            periodoColeta,
                                            localColeta,
                                            enderecoColeta,
                                            localEntrega,
                                            enderecoEntrega,
                                            materialDescricao,
                                            materialDimensoes,
                                            materialPeso,
                                            quantidadeVolume,
                                            obs,
                                            notaFiscal,
                                            valorNotaFiscal,
                                            status,
                                            dataColeta
                                        )
                                        VALUES (
                                            @dataInclusao,
                                            @solicitante,
                                            @setor,
                                            @CC_Projeto,
                                            @dataNecessaria,
                                            @periodoColeta,
                                            @localColeta,
                                            @enderecoColeta,
                                            @localEntrega,
                                            @enderecoEntrega,
                                            @materialDescricao,
                                            @materialDimensoes,
                                            @materialPeso,
                                            @quantidadeVolume,
                                            @obs,
                                            @notaFiscal,
                                            @valorNotaFiscal,
                                            @status,
                                            @dataColeta
                                        );";
            command.Parameters.Add("@dataInclusao", System.Data.DbType.DateTime).Value = coletaModel.dataInclusao;
            command.Parameters.Add("@solicitante", DbType.String).Value = coletaModel.solicitante;
            command.Parameters.Add("@setor", DbType.String).Value = coletaModel.setor;
            command.Parameters.Add("@CC_Projeto", DbType.String).Value = coletaModel.CC_Projeto;
            command.Parameters.Add("@dataNecessaria", System.Data.DbType.DateTime).Value = coletaModel.dataNecessaria;
            command.Parameters.Add("@periodoColeta", DbType.String).Value = coletaModel.periodoColeta;
            command.Parameters.Add("@localColeta", DbType.String).Value = coletaModel.localColeta;
            command.Parameters.Add("@enderecoColeta", DbType.String).Value = coletaModel.enderecoColeta;
            command.Parameters.Add("@localEntrega", DbType.String).Value = coletaModel.localEntrega;
            command.Parameters.Add("@enderecoEntrega", DbType.String).Value = coletaModel.enderecoEntrega;
            command.Parameters.Add("@materialDescricao", DbType.String).Value = coletaModel.materialDescricao;
            command.Parameters.Add("@materialDimensoes", DbType.String).Value = coletaModel.materialDimensoes;
            command.Parameters.Add("@materialPeso", DbType.Double).Value = coletaModel.materialPeso;
            command.Parameters.Add("@quantidadeVolume", DbType.Int32).Value = coletaModel.quantidadeVolume;
            command.Parameters.Add("@obs", DbType.String).Value = coletaModel.obs;
            command.Parameters.Add("@notaFiscal", DbType.String).Value = coletaModel.notaFiscal;
            command.Parameters.Add("@valorNotaFiscal", DbType.Double).Value = coletaModel.valorNotaFiscal;
            command.Parameters.Add("@status", DbType.String).Value = coletaModel.status;
            command.Parameters.Add("@dataColeta", System.Data.DbType.DateTime).Value = coletaModel.dataInclusao;
            command.ExecuteNonQuery();

            command.CommandText = "select last_insert_rowid()";
            Int64 LastRowID64 = (Int64)command.ExecuteScalar();

            int LastRowID = (int)LastRowID64;

            connection.Close();

            return LastRowID;
        }

        public void deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void editar(ColetaModel coletaModel)
        {
            SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING);
            SQLiteCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = @"UPDATE coleta
                                       SET dataInclusao = @dataInclusao,
                                           solicitante = @solicitante,
                                           setor = @setor,
                                           CC_Projeto = @CC_Projeto,
                                           dataNecessaria = @dataNecessaria,
                                           periodoColeta = @periodoColeta,
                                           localColeta = @localColeta,
                                           enderecoColeta = @enderecoColeta,
                                           localEntrega = @localEntrega,
                                           enderecoEntrega = @enderecoEntrega,
                                           materialDescricao = @materialDescricao,
                                           materialDimensoes = @materialDimensoes,
                                           materialPeso = @materialPeso,
                                           quantidadeVolume = @quantidadeVolume,
                                           obs = @obs,
                                           notaFiscal = @notaFiscal,
                                           valorNotaFiscal = @valorNotaFiscal,
                                           transportadora = @transportadora,
                                           valorFrete = @valorFrete,
                                           dataColeta = @dataColeta,
                                           status = @status,
                                           motivoFalha = @motivoFalha
                                     WHERE id = @id;";
            command.Parameters.Add("@id", DbType.Int32).Value = coletaModel.id;
            command.Parameters.Add("@dataInclusao", System.Data.DbType.DateTime).Value = coletaModel.dataInclusao;
            command.Parameters.Add("@solicitante", DbType.String).Value = coletaModel.solicitante;
            command.Parameters.Add("@setor", DbType.String).Value = coletaModel.setor;
            command.Parameters.Add("@CC_Projeto", DbType.String).Value = coletaModel.CC_Projeto;
            command.Parameters.Add("@dataNecessaria", System.Data.DbType.DateTime).Value = coletaModel.dataNecessaria;
            command.Parameters.Add("@periodoColeta", DbType.String).Value = coletaModel.periodoColeta;
            command.Parameters.Add("@localColeta", DbType.String).Value = coletaModel.localColeta;
            command.Parameters.Add("@enderecoColeta", DbType.String).Value = coletaModel.enderecoColeta;
            command.Parameters.Add("@localEntrega", DbType.String).Value = coletaModel.localEntrega;
            command.Parameters.Add("@enderecoEntrega", DbType.String).Value = coletaModel.enderecoEntrega;
            command.Parameters.Add("@materialDescricao", DbType.String).Value = coletaModel.materialDescricao;
            command.Parameters.Add("@materialDimensoes", DbType.String).Value = coletaModel.materialDimensoes;
            command.Parameters.Add("@materialPeso", DbType.Double).Value = coletaModel.materialPeso;
            command.Parameters.Add("@quantidadeVolume", DbType.Int32).Value = coletaModel.quantidadeVolume;
            command.Parameters.Add("@obs", DbType.String).Value = coletaModel.obs;
            command.Parameters.Add("@notaFiscal", DbType.String).Value = coletaModel.notaFiscal;
            command.Parameters.Add("@valorNotaFiscal", DbType.Double).Value = coletaModel.valorNotaFiscal;
            command.Parameters.Add("@transportadora", DbType.String).Value = coletaModel.transportadora;
            command.Parameters.Add("@valorFrete", DbType.Double).Value = coletaModel.valorFrete;
            command.Parameters.Add("@dataColeta", System.Data.DbType.DateTime).Value = coletaModel.dataColeta;
            command.Parameters.Add("@status", DbType.String).Value = coletaModel.status;
            command.Parameters.Add("@motivoFalha", DbType.String).Value = coletaModel.motivoFalha;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IEnumerable<ColetaModel> filtrarPeloStatus(string status)
        {
            List<ColetaModel> coletasPeloStatus = new List<ColetaModel>();
            SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING);
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = $@"SELECT id,
                                           dataInclusao,
                                           solicitante,
                                           setor,
                                           CC_Projeto,
                                           dataNecessaria,
                                           periodoColeta,
                                           localColeta,
                                           enderecoColeta,
                                           localEntrega,
                                           enderecoEntrega,
                                           materialDescricao,
                                           materialDimensoes,
                                           materialPeso,
                                           quantidadeVolume,
                                           obs,
                                           notaFiscal,
                                           valorNotaFiscal,
                                           transportadora,
                                           valorFrete,
                                           dataColeta,
                                           status,
                                           motivoFalha
                                      FROM coleta
                                     WHERE status = ""{status}""
                                     ORDER BY dataNecessaria ASC;";
            connection.Open();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ColetaModel coletaModel = readerToColetaModel(reader);
                    coletasPeloStatus.Add(coletaModel);
                }
            }
            connection.Close();
            return coletasPeloStatus;
        }

        public IEnumerable<ColetaModel> listar()
        {
            List<ColetaModel> coletasPeloStatus = new List<ColetaModel>();
            SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING);
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = $@"SELECT id,
                                           dataInclusao,
                                           solicitante,
                                           setor,
                                           CC_Projeto,
                                           dataNecessaria,
                                           periodoColeta,
                                           localColeta,
                                           enderecoColeta,
                                           localEntrega,
                                           enderecoEntrega,
                                           materialDescricao,
                                           materialDimensoes,
                                           materialPeso,
                                           quantidadeVolume,
                                           obs,
                                           notaFiscal,
                                           valorNotaFiscal,
                                           transportadora,
                                           valorFrete,
                                           dataColeta,
                                           status,
                                           motivoFalha
                                      FROM coleta
                                     WHERE status LIKE ""%""
                                     ORDER BY dataNecessaria ASC;";
            connection.Open();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ColetaModel coletaModel = readerToColetaModel(reader);
                    coletasPeloStatus.Add(coletaModel);
                }
            }
            connection.Close();
            return coletasPeloStatus;
        }

        public IEnumerable<ColetaModel> listarTodasAguardando()
        {
            return filtrarPeloStatus("aguardando");
        }

        public ColetaModel obterPeloId(int id)
        {
            SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING);
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = $@"SELECT id,
                                            dataInclusao,
                                            solicitante,
                                            setor,
                                            CC_Projeto,
                                            dataNecessaria,
                                            periodoColeta,
                                            localColeta,
                                            enderecoColeta,
                                            localEntrega,
                                            enderecoEntrega,
                                            materialDescricao,
                                            materialDimensoes,
                                            materialPeso,
                                            quantidadeVolume,
                                            obs,
                                            notaFiscal,
                                            valorNotaFiscal,
                                            transportadora,
                                            valorFrete,
                                            dataColeta,
                                            status,
                                            motivoFalha
                                        FROM coleta 
                                        WHERE id = @id;";
            connection.Open();
            command.Parameters.Add("@id", DbType.Int32).Value = id;
            ColetaModel coletaModel = new ColetaModel();
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                coletaModel.id = reader.GetInt32(0);
                coletaModel.dataInclusao = reader.GetDateTime(1);
                coletaModel.solicitante = reader.GetString(2);
                coletaModel.setor = reader.GetString(3);
                coletaModel.CC_Projeto = reader.GetString(4);
                coletaModel.dataNecessaria = reader.GetDateTime(5);
                coletaModel.periodoColeta = reader.GetString(6);
                coletaModel.localColeta = reader.GetString(7);
                coletaModel.enderecoColeta = reader.GetString(8);
                coletaModel.localEntrega = reader.GetString(9);
                coletaModel.enderecoEntrega = reader.GetString(10);
                coletaModel.materialDescricao = reader.GetString(11);
                coletaModel.materialDimensoes = reader.GetString(12);
                coletaModel.materialPeso = reader.GetDouble(13);
                coletaModel.quantidadeVolume = reader.GetInt32(14);
                coletaModel.obs = reader.GetString(15);
                coletaModel.notaFiscal = reader["notaFiscal"].ToString();
                coletaModel.valorNotaFiscal = reader.GetDouble(17);
                coletaModel.transportadora = reader.GetString(18);
                coletaModel.valorFrete = reader.GetDouble(19);
                coletaModel.dataColeta = reader.GetDateTime(20);
                coletaModel.status = reader.GetString(21);
                coletaModel.motivoFalha = reader.GetString(22);
            }
            connection.Close();

            return coletaModel;
        }

        ColetaModel readerToColetaModel(SQLiteDataReader reader)
        {
            ColetaModel coletaModel = new ColetaModel();
            coletaModel.id = reader.GetInt32(0);
            coletaModel.dataInclusao = reader.GetDateTime(1);
            coletaModel.solicitante = reader.GetString(2);
            coletaModel.setor = reader.GetString(3);
            coletaModel.CC_Projeto = reader.GetString(4);
            coletaModel.dataNecessaria = reader.GetDateTime(5);
            coletaModel.periodoColeta = reader.GetString(6);
            coletaModel.localColeta = reader.GetString(7);
            coletaModel.enderecoColeta = reader.GetString(8);
            coletaModel.localEntrega = reader.GetString(9);
            coletaModel.enderecoEntrega = reader.GetString(10);
            coletaModel.materialDescricao = reader.GetString(11);
            coletaModel.materialDimensoes = reader.GetString(12);
            coletaModel.materialPeso = reader.GetDouble(13);
            coletaModel.quantidadeVolume = reader.GetInt32(14);
            coletaModel.obs = reader.GetString(15);
            coletaModel.notaFiscal = reader["notaFiscal"].ToString();
            coletaModel.valorNotaFiscal = reader.GetDouble(17);
            coletaModel.transportadora = reader.GetString(18);
            coletaModel.valorFrete = reader.GetDouble(19);
            coletaModel.dataColeta = reader.GetDateTime(20);
            coletaModel.status = reader.GetString(21);
            coletaModel.motivoFalha = reader.GetString(22);
            return coletaModel;
        }
    }
}
