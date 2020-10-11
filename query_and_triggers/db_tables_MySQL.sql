-- *********************************************
-- * SQL MySQL generation                      
-- *--------------------------------------------
-- * DB-MAIN version: 10.0.3              
-- * Generator date: Aug 17 2017              
-- * Generation date: Tue Jun 26 15:22:23 2018 
-- * LUN file: C:\Users\admin\OneDrive\Base Dati\Progetto\StudioProfessionale.lun 
-- * Schema: SchemaLogico/1 
-- ********************************************* 


-- Database Section
-- ________________ 
SET default_storage_engine=INNODB;
create database SchemaLogico;
use SchemaLogico;


-- Tables Section
-- _____________ 

create table allocazione (
     matricola int not null,
     codiceSede int not null,
     constraint ID_allocazione_ID primary key (codiceSede, matricola));

create table CATEGORIA (
     codiceCategoria int not null AUTO_INCREMENT,
     nome varchar(20) not null,
     descrizione varchar(1024) not null,
     constraint ID_CATEGORIA_ID primary key (codiceCategoria));

create table CLIENTE (
     codiceFiscale varchar(16) not null,
     nominativo varchar(20) not null,
     via varchar(35) not null,
     CAP varchar(10) not null,
     citta varchar(34) not null,
     tipo char(1) not null,
     partitaIVA varchar(11),
     codiceSede int not null,
     constraint ID_CLIENTE_ID primary key (codiceFiscale),
     constraint SID_CLIENTE_ID unique (partitaIVA));

create table COSTO_STRUTTURA (
     codiceCostoStruttura int not null AUTO_INCREMENT,
     dataPagamento date not null,
     costo float(1) not null,
     descrizione varchar(1024) not null,
     tipo char(1) not null,
     quantita int default 1,
     codiceSede int not null,
     constraint ID_COSTO_STRUTTURA_ID primary key (codiceCostoStruttura));

create table DIPENDENTE (
     matricola int not null AUTO_INCREMENT,
     nome varchar(20) not null,
     cognome varchar(20) not null,
     via varchar(35) not null,
     CAP varchar(10) not null,
     citta varchar(34) not null,
     costoOrario float(1) not null,
     tipo char(1) not null,
     stipendio int,
     codiceRuolo int not null,
     constraint ID_DIPENDENTE_ID primary key (matricola));

create table FASE (
     codiceFiscale varchar(16) not null,
     codicePratica int not null,
     codicePrestazione int not null,
     matricola int not null,
     inizio datetime not null,
     fine datetime not null,
     descrizione varchar(1024) not null,
     constraint ID_FASE_ID primary key (matricola, codiceFiscale, codicePratica, codicePrestazione, inizio));

create table PRATICA (
     codiceFiscale varchar(16) not null,
     codicePratica int not null AUTO_INCREMENT,
     nome varchar(30) not null,
     dataRichiesta date not null,
     constraint ID_PRATICA_ID primary key (codiceFiscale, codicePratica));

create table PRESTAZIONE (
     codiceFiscale varchar(16) not null,
     codicePratica int not null,
     codicePrestazione int not null AUTO_INCREMENT,
     compenso float(1) default 0 not null,
     durata time not null,
     pagata boolean not null,
     terminata boolean not null,
     codiceSottocategoria int not null,
     constraint ID_PRESTAZIONE_ID primary key (codiceFiscale, codicePratica, codicePrestazione));

create table responsabile (
     codiceFiscale varchar(16) not null,
     matricola int not null,
     dataInizio date not null,
     dataFine date,
     constraint ID_responsabile_ID primary key (codiceFiscale, matricola, dataInizio));

create table RUOLO (
     codiceRuolo int not null AUTO_INCREMENT,
     nome varchar(25) not null,
     constraint ID_RUOLO_ID primary key (codiceRuolo));

create table SEDE (
     codiceSede int not null AUTO_INCREMENT,
     nome varchar(35) not null,
     via varchar(35) not null,
     CAP varchar(10) not null,
     citta varchar(34) not null,
     constraint ID_SEDE_ID primary key (codiceSede));

create table SOTTOCATEGORIA (
     codiceSottocategoria int not null AUTO_INCREMENT,
     nome varchar(20) not null,
     descrizione varchar(1024) not null,
     costoFissoPerCliente float(1) default 0 not null,
     tipoPF boolean not null,
     tipoAZ boolean not null,
     codiceCategoria int not null,
     constraint ID_SOTTOCATEGORIA_ID primary key (codiceSottocategoria));


-- Constraints Section
-- ___________________ 

alter table allocazione add constraint FKall_SED
     foreign key (codiceSede)
     references SEDE (codiceSede);

alter table allocazione add constraint FKall_DIP_FK
     foreign key (matricola)
     references DIPENDENTE (matricola);

-- Not implemented
-- alter table CATEGORIA add constraint ID_CATEGORIA_CHK
--     check(exists(select * from SOTTOCATEGORIA
--                  where SOTTOCATEGORIA.codiceCategoria = codiceCategoria)); 

alter table CLIENTE add constraint FKservizio_FK
     foreign key (codiceSede)
     references SEDE (codiceSede);

alter table COSTO_STRUTTURA add constraint FKsalda_FK
     foreign key (codiceSede)
     references SEDE (codiceSede);

-- Not implemented
-- alter table DIPENDENTE add constraint ID_DIPENDENTE_CHK
--     check(exists(select * from allocazione
--                  where allocazione.matricola = matricola)); 

alter table DIPENDENTE add constraint FKricopre_FK
     foreign key (codiceRuolo)
     references RUOLO (codiceRuolo);

alter table FASE add constraint FKesecuzione
     foreign key (matricola)
     references DIPENDENTE (matricola);

alter table FASE add constraint FKsuddivisione_FK
     foreign key (codiceFiscale, codicePratica, codicePrestazione)
     references PRESTAZIONE (codiceFiscale, codicePratica, codicePrestazione);

alter table PRATICA add constraint FKrichiesta
     foreign key (codiceFiscale)
     references CLIENTE (codiceFiscale);

-- Not implemented
-- alter table PRESTAZIONE add constraint ID_PRESTAZIONE_CHK
--     check(exists(select * from FASE
--                  where FASE.codiceFiscale = codiceFiscale and FASE.codicePratica = codicePratica and FASE.codicePrestazione = codicePrestazione)); 

alter table PRESTAZIONE add constraint FKtipologia_FK
     foreign key (codiceSottocategoria)
     references SOTTOCATEGORIA (codiceSottocategoria);

alter table PRESTAZIONE add constraint FKcomposizione
     foreign key (codiceFiscale, codicePratica)
     references PRATICA (codiceFiscale, codicePratica);

alter table responsabile add constraint FKattribuzione_FK
     foreign key (matricola)
     references DIPENDENTE (matricola);

alter table responsabile add constraint FKassistenza
     foreign key (codiceFiscale)
     references CLIENTE (codiceFiscale);

-- Not implemented
-- alter table RUOLO add constraint ID_RUOLO_CHK
--     check(exists(select * from DIPENDENTE
--                  where DIPENDENTE.codiceRuolo = codiceRuolo)); 

-- Not implemented
-- alter table SEDE add constraint ID_SEDE_CHK
--     check(exists(select * from allocazione
--                  where allocazione.codiceSede = codiceSede)); 

-- Not implemented
-- alter table SEDE add constraint ID_SEDE_CHK
--     check(exists(select * from COSTO_STRUTTURA
--                  where COSTO_STRUTTURA.codiceSede = codiceSede)); 

alter table SOTTOCATEGORIA add constraint FKspecializzazione_FK
     foreign key (codiceCategoria)
     references CATEGORIA (codiceCategoria);


-- Index Section
-- _____________ 

create unique index ID_allocazione_IND
     on allocazione (codiceSede, matricola);

create index FKall_DIP_IND
     on allocazione (matricola);

create unique index ID_CATEGORIA_IND
     on CATEGORIA (codiceCategoria);

create unique index ID_CLIENTE_IND
     on CLIENTE (codiceFiscale);

create unique index SID_CLIENTE_IND
     on CLIENTE (partitaIVA);

create index FKservizio_IND
     on CLIENTE (codiceSede);

create unique index ID_COSTO_STRUTTURA_IND
     on COSTO_STRUTTURA (codiceCostoStruttura);

create index FKsalda_IND
     on COSTO_STRUTTURA (codiceSede);

create unique index ID_DIPENDENTE_IND
     on DIPENDENTE (matricola);

create index FKricopre_IND
     on DIPENDENTE (codiceRuolo);

create unique index ID_FASE_IND
     on FASE (matricola, codiceFiscale, codicePratica, codicePrestazione, inizio);

create index FKsuddivisione_IND
     on FASE (codiceFiscale, codicePratica, codicePrestazione);

create unique index ID_PRATICA_IND
     on PRATICA (codiceFiscale, codicePratica);

create unique index ID_PRESTAZIONE_IND
     on PRESTAZIONE (codiceFiscale, codicePratica, codicePrestazione);

create index FKtipologia_IND
     on PRESTAZIONE (codiceSottocategoria);

create unique index ID_responsabile_IND
     on responsabile (codiceFiscale, matricola, dataInizio);

create index FKattribuzione_IND
     on responsabile (matricola);

create unique index ID_RUOLO_IND
     on RUOLO (codiceRuolo);

create unique index ID_SEDE_IND
     on SEDE (codiceSede);

create unique index ID_SOTTOCATEGORIA_IND
     on SOTTOCATEGORIA (codiceSottocategoria);

create index FKspecializzazione_IND
     on SOTTOCATEGORIA (codiceCategoria);

