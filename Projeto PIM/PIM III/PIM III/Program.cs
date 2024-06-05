// See https://aka.ms/new-console-template for more information
using PIM_III;
using PIM_III.Infraestrutura;


Usuario usuario_teste = new Usuario();

usuario_teste.inicio();



DataRepository data_base = new DataRepository();
data_base.Cadastro_Produtor_DB(usuario_teste);
data_base.Cadastro_Propriedade_DB(usuario_teste);
