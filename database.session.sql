CREATE TABLE vacinas(
	codigo serial primary key,
	nome_vacina VARCHAR(255) NOT NULL,
	tipo_vacina VARCHAR(500) NOT NULL,
  temp_armazenamento integer NOT NULL,
  tem_descongelamento integer NOT NULL,
	validade date
);