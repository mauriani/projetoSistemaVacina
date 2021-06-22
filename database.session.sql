CREATE TABLE vacinas (
	codigo serial PRIMARY KEY,
	nome_Vacina VARCHAR (50) UNIQUE NOT NULL,
  tipo_Vacina VARCHAR (50) UNIQUE NOT NULL,
  validade date,
	temp_Armazenamento VARCHAR (10) NOT NULL,
  temp_Descongelamento VARCHAR (10) NOT NULL,
	created_on TIMESTAMP NOT NULL,      
);