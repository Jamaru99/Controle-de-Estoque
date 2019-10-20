create table Produto(
	Id int not null primary key identity(1,1),
	Descricao varchar(50) not null,
	MP_PA tinyint not null,
	Tamanho int null,
	Preco float not null
);

create table Cliente(
	cnpj_cpf varchar(18) not null primary key,
	razao_social varchar(30) not null,
	inscricao_estadual varchar(16),
	inscricao_municipal varchar(16),
	endereco varchar(60) not null,
	bairro varchar(20) not null,
	municipio varchar(20) not null,
	uf varchar(2) not null,
	pais varchar(20) not null,
	cep varchar(8) not null
);

create table Pedido(
	id int not null primary key identity(1,1),
	cliente_cnpj_cpf varchar(18) not null foreign key references Cliente(cnpj_cpf),
	data_criacao date not null,
	data_entrega date not null,
	[status] varchar(15) not null check([status] in('Pendente', 'Finalizado', 'Cancelado'))
);

create table Itens_pedido(
	id int not null primary key identity(1,1),
	pedido_id int not null foreign key references Pedido(id),
	produto_id int not null foreign key references Produto(Id),
	quantidade int not null,
	[status] varchar(15) not null check([status] in('Atendido', 'Em produção', 'Entregue'))
);

create table Fornecedor(
	cnpj varchar(18) not null primary key,
	razao_social varchar(30) not null,
	inscricao_estadual varchar(16),
	inscricao_municipal varchar(16),
	endereco varchar(60) not null,
	bairro varchar(20) not null,
	municipio varchar(20) not null,
	uf varchar(2) not null,
	pais varchar(20) not null,
	cep varchar(9) not null
);

create table Fornecimento(
	 id int not null primary key identity(1,1),
	 fornecedor_cnpj varchar(18) not null foreign key references Fornecedor(cnpj),
	 produto_id int not null foreign key references Produto(Id)
);

create table Locais(
	id int not null primary key identity(1,1),
	descricao varchar(50) not null
);

create table Estoque(
	id int not null primary key identity(1,1),
	locais_id int not null foreign key references Locais(id),
	itens_pedido_id int not null foreign key references Itens_pedido(id),
	produto_id int not null foreign key references Produto(Id),
	[status] varchar(15) not null check([status] in('Disponível', 'Vendido', 'Reservado')),
	quantidade int not null
);

create table Ordem_producao(
	id int not null primary key identity(1,1),
	itens_pedido_id int not null foreign key references Itens_pedido(id),
	produto_id int not null foreign key references Produto(Id),
	[status] varchar(15) not null check([status] in('Em produção', 'Finalizada', 'Cancelada')),
	quantidade int not null
);