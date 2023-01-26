--
-- File generated with SQLiteStudio v3.1.1 on qua jan 25 21:21:42 2023
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: coleta
CREATE TABLE IF NOT EXISTS coleta (
    id                INTEGER PRIMARY KEY AUTOINCREMENT,
    dataInclusao      DATE    NOT NULL ON CONFLICT FAIL,
    solicitante       STRING  NOT NULL ON CONFLICT FAIL,
    setor             STRING  NOT NULL ON CONFLICT FAIL,
    CC_Projeto        STRING  NOT NULL ON CONFLICT FAIL,
    dataNecessaria    DATE    NOT NULL ON CONFLICT FAIL,
    periodoColeta     STRING  NOT NULL ON CONFLICT FAIL,
    localColeta       STRING  NOT NULL ON CONFLICT FAIL,
    enderecoColeta    STRING  NOT NULL ON CONFLICT FAIL,
    localEntrega      TEXT    NOT NULL ON CONFLICT FAIL,
    enderecoEntrega   TEXT    NOT NULL ON CONFLICT FAIL,
    materialDescricao STRING  NOT NULL ON CONFLICT FAIL,
    materialDimensoes STRING  NOT NULL ON CONFLICT FAIL,
    materialPeso      DOUBLE  NOT NULL ON CONFLICT FAIL,
    quantidadeVolume  INTEGER NOT NULL ON CONFLICT FAIL,
    obs               TEXT    NOT NULL ON CONFLICT FAIL,
    notaFiscal        STRING  NOT NULL ON CONFLICT FAIL,
    valorNotaFiscal   DOUBLE  NOT NULL ON CONFLICT FAIL,
    transportadora    STRING  DEFAULT ('a ser definido'),
    valorFrete        DOUBLE  DEFAULT (0),
    dataColeta        DATE    DEFAULT ('2022-01-01 00:00:00'),
    status            STRING  DEFAULT ('aguardando'),
    motivoFalha       STRING  DEFAULT ""
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;