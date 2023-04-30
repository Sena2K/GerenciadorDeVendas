using System.Collections.Generic;

namespace GerenciadorDeVendas.Modelo
{
    public class Estado
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public List<string> Cidades { get; set; }

        public Estado(string nome, string sigla, List<string> cidades)
        {
            Nome = nome;
            Sigla = sigla;
            Cidades = cidades;
        }
    }

    public static class EstadosBrasileiros
    {
        public static List<Estado> ListaEstados = new List<Estado>()
        {
            new Estado("Acre", "AC", new List<string>()
            {
                "Rio Branco",
                "Cruzeiro do Sul",
                "Tarauacá",
                "Sena Madureira",
                "Feijó",
                "Brasiléia",
                "Plácido de Castro",
                "Xapuri",
                "Epitaciolândia",
                "Marechal Thaumaturgo"
            }),
            new Estado("Alagoas", "AL", new List<string>()
            {
                "Maceió",
                "Arapiraca",
                "Rio Largo",
                "Palmeira dos Índios",
                "Marechal Deodoro",
                "São Miguel dos Campos",
                "Penedo",
                "Coruripe",
                "Delmiro Gouveia",
                "Campo Alegre"
            }),
            new Estado("Amapá", "AP", new List<string>()
            {
                "Macapá",
                "Santana",
                "Laranjal do Jari",
                "Oiapoque",
                "Mazagão",
                "Porto Grande",
                "Tartarugalzinho",
                "Pedra Branca do Amapari",
                "Serra do Navio",
                "Cutias"
            }),
            new Estado("Amazonas", "AM", new List<string>()
            {
                "Manaus",
                "Parintins",
                "Itacoatiara",
                "Manacapuru",
                "Coari",
                "Tefé",
                "Tabatinga",
                "São Gabriel da Cachoeira",
                "Maués",
                "Humaitá"
            }),
            new Estado("Bahia", "BA", new List<string>()
            {
                "Salvador",
                "Feira de Santana",
                "Vitória da Conquista",
                "Camaçari",
                "Itabuna",
                "Juazeiro",
                "Lauro de Freitas",
                "Ilhéus",
                "Eunápolis",
                "Alagoinhas"
            }),
            new Estado("Ceará", "CE", new List<string>()
            {
                "Fortaleza",
                "Caucaia",
                "Juazeiro do Norte",
                "Maracanaú",
                "Sobral",
                "Crato",
                "Itapipoca",
                "Maranguape",
                "Iguatu",
                "Quixadá"
            }),

            new Estado("DF", "Distrito Federal", new List<string>()
            {
                "Brasília",
                "Ceilândia",
                "Taguatinga",
                "Samambaia",
                "Santa Maria",
                "Recanto das Emas",
                "Gama",
                "Planaltina",
                "Sobradinho",
                "Paranoá"
            }),
            new Estado("ES", "Espírito Santo", new List<string>()
            {
                "Vitória",
                "Vila Velha",
                "Serra",
                "Cariacica",
                "Cachoeiro de Itapemirim",
                "Linhares",
                "São Mateus",
                "Guarapari",
                "Colatina",
                "Aracruz"
            }),
            new Estado("GO", "Goiás", new List<string>()
            {
                "Goiânia",
                "Aparecida de Goiânia",
                "Anápolis",
                "Rio Verde",
                "Luziânia",
                "Águas Lindas de Goiás",
                "Valparaíso de Goiás",
                "Trindade",
                "Formosa",
                "Novo Gama"
            }),
            new Estado("MA", "Maranhão", new List<string>()
            {
                "São Luís",
                "Imperatriz",
                "Timon",
                "Caxias",
                "Codó",
                "Paço do Lumiar",
                "Açailândia",
                "Bacabal",
                "Balsas",
                "Santa Inês"
            }),
            new Estado("MT", "Mato Grosso", new List<string>()
            {
                "Cuiabá",
                "Várzea Grande",
                "Rondonópolis",
                "Sinop",
                "Tangará da Serra",
                "Cáceres",
                "Sorriso",
                "Lucas do Rio Verde",
                "Primavera do Leste",
                "Barra do Garças"
            }),
            new Estado("MS", "Mato Grosso do Sul", new List<string>()
            {
                "Campo Grande",
                "Dourados",
                "Três Lagoas",
                "Corumbá",
                "Ponta Porã",
                "Naviraí",
                "Nova Andradina",
                "Aquidauana",
                "Sidrolândia",
                "Paranaíba"
            }),
            new Estado("MG", "Minas Gerais", new List<string>()
            {
                "Belo Horizonte",
                "Uberlândia",
                "Contagem",
                "Juiz de Fora",
                "Betim",
                "Montes Claros",
                "Ribeirão das Neves",
                "Uberaba",
                "Governador Valadares",
                "Ipatinga"
            }),
            new Estado("PA", "Pará",
        new List<string>()
        {
            "Belém",
            "Ananindeua",
            "Santarém",
            "Marabá",
            "Parauapebas",
            "Castanhal",
            "Abadia de Goiás",
            "Açailândia",
            "Afuá",
            "Água Azul do Norte"
        }
    ),
            new Estado("PB", "Paraíba",
        new List<string>()
        {
            "João Pessoa",
            "Campina Grande",
            "Santa Rita",
            "Patos",
            "Bayeux",
            "Sousa",
            "Cajazeiras",
            "Cabedelo",
            "Guarabira",
            "Sapé"
        }
    ),
            new Estado("PR", "Paraná",
        new List<string>()
        {
            "Curitiba",
            "Londrina",
            "Maringá",
            "Ponta Grossa",
            "Cascavel",
            "São José dos Pinhais",
            "Foz do Iguaçu",
            "Colombo",
            "Guarapuava",
            "Paranaguá"
        }
    ),
            new Estado("PE", "Pernambuco",
        new List<string>()
        {
            "Recife",
            "Jaboatão dos Guararapes",
            "Olinda",
            "Caruaru",
            "Petrolina",
            "Paulista",
            "Cabo de Santo Agostinho",
            "Camaragibe",
            "Garanhuns",
            "Vitória de Santo Antão"
        }
    ),
            new Estado("PI", "Piauí",
        new List<string>()
        {
            "Teresina",
            "Parnaíba",
            "Picos",
            "Piripiri",
            "Floriano",
            "Campo Maior",
            "Pedro II",
            "Altos",
            "Barras",
            "Esperantina"
        }
    ),
            new Estado("RJ", "Rio de Janeiro",
        new List<string>()
        {
            "Rio de Janeiro",
            "São Gonçalo",
            "Duque de Caxias",
            "Nova Iguaçu",
            "Niterói",
            "Belford Roxo",
            "Campos dos Goytacazes",
            "São João de Meriti",
            "Petrópolis",
            "Volta Redonda"
        }
    ),
            new Estado("RN", "Rio Grande do Norte",
        new List<string>()
        {
            "Natal",
            "Mossoró",
            "Parnamirim",
            "São Gonçalo do Amarante",
            "Macaíba",
            "Ceará-Mirim",
            "Caicó",
            "Assu",
            "Currais Novos",
            "Santa Cruz"
        }
    ),
            new Estado("RS", "Rio Grande do Sul",
        new List<string>()
        {
            "Porto Alegre",
            "Caxias do Sul",
            "Pelotas",
            "Canoas",
            "Santa Maria",
            "Gravataí",
            "Viamão",
            "Novo Hamburgo",
            "São Leopoldo",
            "Rio Grande"
        }
    ),
            new Estado("RO", "Rondônia",
        new List<string>()
        {
            "Porto Velho",
            "Ji-Paraná",
            "Ariquemes",
            "Vilhena",
            "Cacoal",
            "Rolim de Moura",
            "Guajará-Mirim",
            "Pimenta Bueno",
            "Nova Mamoré",
            "Machadinho D'Oeste"
        }
    ),
            new Estado("RR", "Roraima",
        new List<string>()
        {
            "Boa Vista",
            "Caracaraí",
            "Mucajaí",
            "Rorainópolis",
            "São Luiz do Anauá",
            "Alto Alegre",
            "Pacaraima",
            "São João da Baliza",
            "Cantá",
            "Iracema"
        }
    ),
            new Estado("SC", "Santa Catarina",
        new List<string>()
        {
            "Joinville",
            "Florianópolis",
            "Blumenau",
            "São José",
            "Chapecó",
            "Criciúma",
            "Itajaí",
            "Jaraguá do Sul",
            "Palhoça",
            "Lages"
        }
    ),
            new Estado("SP", "São Paulo",
        new List<string>()
        {
            "São Paulo",
            "Guarulhos",
            "Campinas",
            "São Bernardo do Campo",
            "Santo André",
            "São José dos Campos",
            "Osasco",
            "Ribeirão Preto",
            "Sorocaba",
            "Mauá"
        }
    ),
            new Estado("SE", "Sergipe",
        new List<string>()
        {
            "Aracaju",
            "Nossa Senhora do Socorro",
            "Lagarto",
            "Itabaiana",
            "Estância",
            "Tobias Barreto",
            "Itabaianinha",
            "Simão Dias",
            "Capela",
            "Canindé de São Francisco"
        }
    ),
            new Estado("TO", "Tocantins",
        new List<string>()
        {
            "Palmas",
            "Araguaína",
            "Gurupi",
            "Porto Nacional",
            "Paraíso do Tocantins",
            "Guaraí",
            "Formoso do Araguaia",
            "Tocantinópolis",
            "Colinas do Tocantins",
            "Miracema do Tocantins"
        }
    ) };

    }
}