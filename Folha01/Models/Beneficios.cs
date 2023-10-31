namespace Folha01.Models
{
    public class Beneficios
    {
    }
}


/*Create table [Beneficios](
[ID Beneficios] int not null primary Key,
[RescisãoFuncionario] varchar(100) not null,
[HorasExtras] varchar(100),
[VA] decimal (5, 2) not null,
[VT] decimal (5,2) not null,
[ID Funcionario] int not null,
[Codigo de Contrato] int not null,
foreign key ([ID Funcionario]) references [Funcionario] ([id Funcionario]),
foreign key ([Codigo de Contrato]) references [Contrato] ([ID Cargo])
);*/