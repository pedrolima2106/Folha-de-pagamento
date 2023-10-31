namespace Folha01.Models
{
    public class Holerite
    {
    }
}

/*Create table [Holerites](
[ID Holerite] int not null primary key,
[ID_Funcionario] int not null,
[Codigo_Contrato] int not null,
[ID_Beneficios] int not null,
[ID_Frequencia] int not null,
[Data_Admissao] date,
[Data_Atual] date,
[salario_base] decimal (10, 2),
[salario_liquido] decimal (10, 2),
foreign key ([Codigo_Contrato]) references [Contrato] ([ID Cargo]),
foreign key ([ID_Funcionario]) references [Funcionario] ([id Funcionario]),
foreign key ([ID_Beneficios]) references [Beneficios] ([ID Beneficios]),
foreign key ([ID_Frequencia]) references [Frequencia] ([id Frequencia])
);*/