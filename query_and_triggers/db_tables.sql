-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Creato il: Lug 10, 2018 alle 10:43
-- Versione del server: 10.2.14-MariaDB
-- Versione PHP: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studioprofessionale`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `account`
--

DROP TABLE IF EXISTS `account`;
CREATE TABLE IF NOT EXISTS `account` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `matricola` int(11) NOT NULL,
  `amministratore` tinyint(4) NOT NULL DEFAULT 0,
  PRIMARY KEY (`username`),
  KEY `matricola` (`matricola`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dump dei dati per la tabella `account`
--

INSERT INTO `account` (`username`, `password`, `matricola`, `amministratore`) VALUES
('federicobianchi', 'password', 4, 1),
('giuseppeverdi', 'password', 2, 0),
('mariorossi', 'password', 1, 0),
('stefaniabianchi', 'password', 3, 0);

-- --------------------------------------------------------

--
-- Struttura della tabella `allocazione`
--

DROP TABLE IF EXISTS `allocazione`;
CREATE TABLE IF NOT EXISTS `allocazione` (
  `matricola` int(11) NOT NULL,
  `codiceSede` int(11) NOT NULL,
  PRIMARY KEY (`codiceSede`,`matricola`),
  UNIQUE KEY `ID_allocazione_IND` (`codiceSede`,`matricola`),
  KEY `FKall_DIP_IND` (`matricola`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dump dei dati per la tabella `allocazione`
--

INSERT INTO `allocazione` (`matricola`, `codiceSede`) VALUES
(1, 1),
(3, 1),
(4, 1),
(2, 2),
(3, 2),
(4, 2);

-- --------------------------------------------------------

--
-- Struttura della tabella `categoria`
--

DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `codiceCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(20) NOT NULL,
  `descrizione` varchar(1024) NOT NULL,
  PRIMARY KEY (`codiceCategoria`),
  UNIQUE KEY `ID_CATEGORIA_IND` (`codiceCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Dump dei dati per la tabella `categoria`
--

INSERT INTO `categoria` (`codiceCategoria`, `nome`, `descrizione`) VALUES
(1, 'CONTENZIOSO', ''),
(2, 'ACCESSO', ''),
(3, 'AGGIORNAMENTO', ''),
(4, 'CONSULENZA', ''),
(5, 'BILANCIO', ''),
(6, 'COMUNICAZIONE', ''),
(7, 'DICHIARAZIONE', ''),
(8, 'CONTABILITA', ''),
(9, 'PRATICA', ''),
(10, 'ATTIVITA', ''),
(11, 'CARICA', ''),
(12, 'STAMPE', '');

-- --------------------------------------------------------

--
-- Struttura della tabella `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `codiceFiscale` varchar(16) NOT NULL,
  `nominativo` varchar(20) NOT NULL,
  `via` varchar(35) NOT NULL,
  `CAP` varchar(10) NOT NULL,
  `citta` varchar(34) NOT NULL,
  `tipo` char(1) NOT NULL,
  `partitaIVA` varchar(11) DEFAULT NULL,
  `codiceSede` int(11) NOT NULL,
  PRIMARY KEY (`codiceFiscale`),
  UNIQUE KEY `ID_CLIENTE_IND` (`codiceFiscale`),
  UNIQUE KEY `SID_CLIENTE_ID` (`partitaIVA`),
  UNIQUE KEY `SID_CLIENTE_IND` (`partitaIVA`),
  KEY `FKservizio_IND` (`codiceSede`)
) ;

--
-- Dump dei dati per la tabella `cliente`
--

INSERT INTO `cliente` (`codiceFiscale`, `nominativo`, `via`, `CAP`, `citta`, `tipo`, `partitaIVA`, `codiceSede`) VALUES
('BNCGRG01S27I917O', 'Bianchi Giorgia', 'Via Lentate sul Seveso 183', '24050', 'Pumenengo', 'P', NULL, 1),
('BNCGRG04C10E750Z', 'Bianchi Giorgia', 'Via Assoro 133', '95039', 'Trecastagni', 'P', NULL, 2),
('BNCLSU02D04C919V', 'Bianchi Luisa', 'Via Sarezzo 248', '51031', 'Agliana', 'P', NULL, 2),
('BNCLSU02S08G837K', 'Bianchi Luisa', 'Via Teor 75', '82011', 'Airola', 'P', NULL, 1),
('BNCMTN00D16C188G', 'Bianchi Martina', 'Via Pacentro 221', '24060', 'Bolgare', 'A', NULL, 2),
('BNCRRA04L59L845V', 'Bianchi Aurora', 'Via Centuripe 96', '23878', 'Verderio Superiore', 'P', NULL, 2),
('BNCRRA95S10D468Q', 'Bianchi Aurora', 'Via Treville 42', '90032', 'Bisacquino', 'A', NULL, 2),
('BNCSFO03T26I604A', 'Bianchi Sofia', 'Via Baldissero d\'Alba 91', '36020', 'Zovencedo', 'A', NULL, 1),
('BNCSFO07E49B771A', 'Bianchi Sofia', 'Via Sporminore 12', '36020', 'Campiglia dei Berici', 'P', NULL, 1),
('FRNCHR00T60Z712A', 'Farina Chiara', 'Via San Sossio Baronia 13', '9020', 'Ussaramanna', 'A', NULL, 2),
('FRNMTN97P58E118M', 'Farina Martina', 'Via Alpignano 37', '71012', 'Rodi Garganico', 'P', NULL, 1),
('FRNRRA07R44Z209Z', 'Farina Aurora', 'Via Avolasca 150', '14040', 'Castelletto Molina', 'P', NULL, 1),
('FRNSFO95P56A363I', 'Farina Sofia', 'Via Barbiano 165', '81055', 'Santa Maria Capua Vetere', 'P', NULL, 2),
('FRNSLV98A64C547S', 'Farina Silvia', 'Via Roncaro 229', '21040', 'Venegono Inferiore', 'A', NULL, 1),
('FRNSRA06L09A292X', 'Farina Sara', 'Via Telve di Sopra 55', '60030', 'Santa Maria Nuova', 'A', NULL, 2),
('FRNSRA97L08D103H', 'Farina Sara', 'Via Gosaldo 248', '85020', 'Atella', 'A', NULL, 1),
('FRRGRG00R24B943H', 'Ferrari Giorgia', 'Via Cairo Montenotte 130', '67012', 'Cagnano Amiterno', 'P', NULL, 1),
('FRRNTN02A65A839O', 'Ferrari Antonia', 'Via Malvagna 185', '66037', 'Sant\'Eusanio del Sangro', 'P', NULL, 1),
('FRRNTN06D25G096I', 'Ferrari Antonia', 'Via Gaby 126', '46049', 'Volta Mantovana', 'A', NULL, 2),
('FRRSFO00C50H570T', 'Ferrari Sofia', 'Via Castelmarte 123', '87076', 'Villapiana', 'P', NULL, 1),
('FRRSRA99M64F675L', 'Ferrari Sara', 'Via Noci 175', '54016', 'Licciana Nardi', 'P', NULL, 2),
('GNTGRG02T16B734V', 'Gentile Giorgia', 'Via Origgio 22', '36012', 'Asiago', 'P', NULL, 1),
('GNTRRA07B03G260W', 'Gentile Aurora', 'Via Bardolino 53', '81014', 'Capriati a Volturno', 'P', NULL, 2),
('GNTSLV95R04H964P', 'Gentile Silvia', 'Via Rignano Flaminio 235', '32046', 'San Vito di Cadore', 'P', NULL, 1),
('GNTSLV97S07E164F', 'Gentile Silvia', 'Via Valmadrera 237', '36050', 'Quinto Vicentino', 'A', NULL, 1),
('LNGCHR97T09G961I', 'Longo Chiara', 'Via Loreto Aprutino 124', '53036', 'Poggibonsi', 'P', NULL, 2),
('LNGGLI05T50B847N', 'Longo Giulia', 'Via Radicondoli 55', '20865', 'Usmate Velate', 'P', NULL, 2),
('LNGLSS00L52E794X', 'Longo Alessia', 'Via Condrï¿½ 31', '84077', 'Torre Orsaia', 'A', NULL, 2),
('LNGSFO08A51A039N', 'Longo Sofia', 'Via Condrï¿½ 214', '84010', 'Sant\'Egidio del Monte Albino', 'P', NULL, 2),
('LNGSFO98E04B715A', 'Longo Sofia', 'Via Ceggia 187', '74027', 'San Giorgio Ionico', 'P', NULL, 2),
('LNGSRA08L25F708X', 'Longo Sara', 'Via Illasi 58', '83020', 'Pago del Vallo di Lauro', 'P', NULL, 2),
('MRTCHR02S04E441W', 'Martini Chiara', 'Via Sini 221', '33040', 'Premariacco', 'A', NULL, 1),
('MRTCHR05A59L345X', 'Martini Chiara', 'Via Rotello 70', '41026', 'Pavullo nel Frignano', 'A', NULL, 1),
('MRTCHR07E04H856B', 'Martini Chiara', 'Via Alzano Scrivia 60', '45021', 'Badia Polesine', 'P', NULL, 2),
('MRTGRG95R63L829N', 'Martini Giorgia', 'Via Avelengo 17', '89039', 'Plati', 'A', NULL, 1),
('MRTLSU02S61I600H', 'Martini Luisa', 'Via Samassi 138', '89010', 'Varapodio', 'A', NULL, 2),
('MRTNTN03D13G802I', 'Martini Antonia', 'Via San Benedetto Belbo 6', '39040', 'Cortina sulla Strada del Vino', 'P', NULL, 1),
('MRTSFO02L59G606H', 'Martini Sofia', 'Via Capoterra 30', '35048', 'Stanghella', 'P', NULL, 2),
('MRTSRA04D46G095F', 'Martini Sara', 'Via Chiusanico 181', '62032', 'Camerino', 'P', NULL, 2),
('NRENTN98R58M848T', 'Neri Antonia', 'Via Ruoti 210', '9010', 'Pula', 'P', NULL, 2),
('NRERRA04P11D501S', 'Neri Aurora', 'Via Adrara San Martino 178', '30', 'Rocca di Cave', 'A', NULL, 2),
('NRERRA96R41E160R', 'Neri Aurora', 'Via Rio Marina 4', '67048', 'Rocca di Mezzo', 'P', NULL, 1),
('NRESRA02C62F420E', 'Neri Sara', 'Via Prata d\'Ansidonia 116', '28853', 'Druogno', 'P', NULL, 2),
('NRESRA02L19L550B', 'Neri Sara', 'Via Zero Branco 75', '30025', 'Fossalta di Portogruaro', 'P', NULL, 2),
('RSSGLI04P13G784I', 'Russo Giulia', 'Via Magliano de\' Marsi 178', '73020', 'Giurdignano', 'P', NULL, 2),
('RSSLSS03D67D858D', 'Rossi Alessia', 'Via Custonaci 184', '84030', 'Caggiano', 'P', NULL, 1),
('RSSLSS05M50E856W', 'Russo Alessia', 'Via San Marcellino 136', '14046', 'Bruno', 'A', NULL, 2),
('RSSMRA01A67I995F', 'Russo Maria', 'Via Valmacca 98', '87015', 'Laino Castello', 'P', NULL, 2),
('RSSMRA03C25I653N', 'Rossi Maria', 'Via Brusasco 239', '10060', 'Osasco', 'A', NULL, 2),
('RSSMRA04T47B067T', 'Rossi Maria', 'Via Arcole 127', '28897', 'Valstrona', 'P', NULL, 1),
('RSSMRA08C53L181Z', 'Russo Maria', 'Via Alcara Li Fusi 212', '13864', 'Crevacuore', 'A', NULL, 2),
('RSSMTN96M65B619X', 'Russo Martina', 'Via Montebuono 231', '13037', 'Serravalle Sesia', 'P', NULL, 1),
('RSSNTN02H12H843L', 'Russo Antonia', 'Via Vidigulfo 161', '10094', 'Giaveno', 'P', NULL, 1),
('RSSNTN96D10D445N', 'Rossi Antonia', 'Via Morro Reatino 232', '38050', 'Novaledo', 'A', NULL, 1),
('RSSSLV05B09H949F', 'Russo Silvia', 'Via Vasanello 91', '84018', 'Scafati', 'P', NULL, 1),
('RSSSLV96B28G141J', 'Rossi Silvia', 'Via Poggio Nativo 246', '48025', 'Riolo Terme', 'A', NULL, 1),
('RSSSLV96M49I871D', 'Rossi Silvia', 'Via Porto Mantovano 58', '9024', 'Nuraminis', 'A', NULL, 1),
('RSSSRA07R48A677M', 'Rossi Sara', 'Via Torrita di Siena 57', '8030', 'Escolca', 'P', NULL, 2),
('SPSCHR96M43B812B', 'Esposito Chiara', 'Via Battaglia Terme 20', '66050', 'San Buono', 'A', NULL, 1),
('SPSCHR99D10G630J', 'Esposito Chiara', 'Via San Colombano Belmonte 67', '27010', 'Santa Cristina e Bissone', 'P', NULL, 1),
('SPSGRG05D43L957H', 'Esposito Giorgia', 'Via Segrate 78', '38038', 'Tesero', 'P', NULL, 2),
('SPSGRG97M21A776Q', 'Esposito Giorgia', 'Via Ceresara 107', '98023', 'Furci Siculo', 'A', NULL, 2),
('SPSLSU07L04I911D', 'Esposito Luisa', 'Via Aquila d\'Arroscia 234', '11010', 'Avise', 'P', NULL, 2),
('SPSMRA06L21C879R', 'Esposito Maria', 'Via Palomonte 7', '21051', 'Arcisate', 'A', NULL, 2),
('SPSRRA03T06H489M', 'Esposito Aurora', 'Via Gallicano nel Lazio 168', '88841', 'Isola di Capo Rizzuto', 'A', NULL, 1),
('SRRGLI96D24D505Z', 'Serra Giulia', 'Via San Cesareo 74', '75019', 'Tricarico', 'P', NULL, 1),
('SRRGRG00M22B833J', 'Serra Giorgia', 'Via Cannalonga 215', '15042', 'Bassignana', 'P', NULL, 1),
('SRRLSS04L51C589G', 'Serra Alessia', 'Via Albiano 96', '62019', 'Recanati', 'P', NULL, 2),
('SRRLSS95S45B446G', 'Serra Alessia', 'Via Casalbuono 83', '9040', 'Armungia', 'A', NULL, 2),
('SRRLSS96S01D688G', 'Serra Alessia', 'Via Coazzolo 162', '84010', 'Scala', 'P', NULL, 1),
('SRRNTN08B03E680R', 'Serra Antonia', 'Via Villa Literno 2', '93010', 'Sutera', 'A', NULL, 1),
('SRRSFO03T55E791S', 'Serra Sofia', 'Via Bagnaria Arsa 198', '15050', 'Pozzol Groppo', 'P', NULL, 1),
('SRRSLV96A45H888W', 'Serra Silvia', 'Via Rossano Veneto 128', '84030', 'Sanza', 'A', NULL, 2),
('TSTGRG08C44F144H', 'Testa Giorgia', 'Via Zafferana Etnea 153', '84070', 'San Mauro Cilento', 'P', NULL, 1),
('TSTLSU01R53B769A', 'Testa Luisa', 'Via Melissa 149', '29010', 'Calendasco', 'A', NULL, 1),
('TSTMRA00P22D875P', 'Testa Maria', 'Via Lierna 198', '17047', 'Quiliano', 'A', NULL, 2),
('TSTMTN04C22G543C', 'Testa Martina', 'Via Albese con Cassano 179', '60036', 'Montecarotto', 'P', NULL, 1),
('TSTMTN95L08F687X', 'Testa Martina', 'Via Chiusano di San Domenico 9', '12040', 'Salmour', 'A', NULL, 1),
('TSTRRA96T47D745O', 'Testa Aurora', 'Via Dolcï¿½ 2', '55030', 'Giuncugnano', 'P', NULL, 1),
('TSTSFO97T28L359Q', 'Testa Sofia', 'Via Lozzo Atestino 178', '10080', 'Ronco Canavese', 'P', NULL, 1),
('VRDCHR97D23B258O', 'Verdi Chiara', 'Via Nureci 168', '88842', 'Cutro', 'A', NULL, 2),
('VRDGLI96S13D715D', 'Verdi Giulia', 'Via Villar Perosa 105', '46014', 'Castellucchio', 'A', NULL, 2),
('VRDLSU99L50H517Z', 'Verdi Luisa', 'Via Morciano di Romagna 55', '24040', 'Isso', 'A', NULL, 2),
('VRDMRA05S55H361G', 'Verdi Maria', 'Via Ispica 221', '9040', 'Ballao', 'A', NULL, 1),
('VRDMRA95D17B109X', 'Verdi Maria', 'Via Taleggio 123', '39017', 'Scena', 'A', NULL, 1),
('VRDMTN95T06E606G', 'Verdi Martina', 'Via Saronno 21', '60', 'Castelnuovo di Porto', 'P', NULL, 1),
('VRDMTN98P44H384T', 'Verdi Martina', 'Via San Martino Siccomario 235', '87036', 'Rende', 'P', NULL, 2),
('VRDSFO99L09B057C', 'Verdi Sofia', 'Via Giustino 24', '50033', 'Firenzuola', 'A', NULL, 2),
('VRDSRA96C55L375S', 'Verdi Sara', 'Via Griante 22', '80040', 'San Gennaro Vesuviano', 'P', NULL, 1),
('VTLGLI07R56C112R', 'Vitale Giulia', 'Via Poggio Mirteto 216', '15075', 'Mornese', 'A', NULL, 2),
('VTLGLI07R63B505D', 'Vitale Giulia', 'Via Villaga 92', '10070', 'Varisella', 'P', NULL, 1),
('VTLGRG98R09G754S', 'Vitale Giorgia', 'Via Firmo 172', '24060', 'Parzanica', 'A', NULL, 1),
('VTLLSS97T44C928R', 'Vitale Alessia', 'Via Camo 31', '22060', 'Carugo', 'P', NULL, 1),
('VTLLSU97H66G812R', 'Vitale Luisa', 'Via Villa Latina 203', '56036', 'Palaia', 'P', NULL, 1),
('VTLMRA01C17F123O', 'Vitale Maria', 'Via Rio nell\'Elba 169', '52024', 'Loro Ciuffenna', 'A', NULL, 1),
('VTLMTN97H59D751M', 'Vitale Martina', 'Via Fiesso d\'Artico 141', '24030', 'Costa Valle Imagna', 'A', NULL, 2),
('VTLNTN98A66H511P', 'Vitale Antonia', 'Via Orgosolo 187', '90030', 'Bolognetta', 'P', NULL, 2),
('VTLRRA97B01L435S', 'Vitale Aurora', 'Via Montoro Superiore 97', '39020', 'Sluderno', 'P', NULL, 1),
('VTLSRA04L49G760T', 'Vitale Sara', 'Via Candia Canavese 87', '22030', 'Sormano', 'P', NULL, 1),
('VTLSRA96D42D348F', 'Vitale Sara', 'Via Arluno 16', '15060', 'Rocchetta Ligure', 'P', NULL, 2);

-- --------------------------------------------------------

--
-- Struttura della tabella `costo_struttura`
--

DROP TABLE IF EXISTS `costo_struttura`;
CREATE TABLE IF NOT EXISTS `costo_struttura` (
  `codiceCostoStruttura` int(11) NOT NULL AUTO_INCREMENT,
  `dataPagamento` date NOT NULL,
  `costo` float NOT NULL,
  `descrizione` varchar(1024) NOT NULL,
  `tipo` char(1) NOT NULL,
  `quantita` int(11) DEFAULT 1,
  `codiceSede` int(11) NOT NULL,
  PRIMARY KEY (`codiceCostoStruttura`),
  UNIQUE KEY `ID_COSTO_STRUTTURA_IND` (`codiceCostoStruttura`),
  KEY `FKsalda_IND` (`codiceSede`)
) ;

--
-- Dump dei dati per la tabella `costo_struttura`
--

INSERT INTO `costo_struttura` (`codiceCostoStruttura`, `dataPagamento`, `costo`, `descrizione`, `tipo`, `quantita`, `codiceSede`) VALUES
(1, '2018-06-10', 10, 'bolli', 'M', 3, 1),
(2, '2018-06-10', 100, 'acqua', 'P', NULL, 1),
(3, '2018-06-10', 100, 'acqua', 'P', NULL, 2),
(4, '2018-06-10', 100, 'luce', 'P', NULL, 1),
(5, '2018-06-10', 300, 'pc rotto', 'I', NULL, 2);

-- --------------------------------------------------------

--
-- Struttura della tabella `dipendente`
--

DROP TABLE IF EXISTS `dipendente`;
CREATE TABLE IF NOT EXISTS `dipendente` (
  `matricola` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(20) NOT NULL,
  `cognome` varchar(20) NOT NULL,
  `via` varchar(35) NOT NULL,
  `CAP` varchar(10) NOT NULL,
  `citta` varchar(34) NOT NULL,
  `costoOrario` float NOT NULL,
  `tipo` char(1) NOT NULL,
  `stipendio` int(11) DEFAULT NULL,
  `codiceRuolo` int(11) NOT NULL,
  PRIMARY KEY (`matricola`),
  UNIQUE KEY `ID_DIPENDENTE_IND` (`matricola`),
  KEY `FKricopre_IND` (`codiceRuolo`)
) ;

--
-- Dump dei dati per la tabella `dipendente`
--

INSERT INTO `dipendente` (`matricola`, `nome`, `cognome`, `via`, `CAP`, `citta`, `costoOrario`, `tipo`, `stipendio`, `codiceRuolo`) VALUES
(1, 'Mario', 'Rossi', 'via Stoccolma 98', '61122', 'Pesaro', 20, 'I', 3200, 3),
(2, 'Giuseppe', 'Verdi', 'via Matteotti 56', '61122', 'Pesaro', 12, 'I', 1920, 1),
(3, 'Stefania', 'Bianchi', 'via Domeniconi 88', '61032', 'Fano', 11, 'C', NULL, 2),
(4, 'Federico', 'Bianchi', 'via Grassi 43', '61032', 'Fano', 10, 'I', 1600, 5);

-- --------------------------------------------------------

--
-- Struttura della tabella `fase`
--

DROP TABLE IF EXISTS `fase`;
CREATE TABLE IF NOT EXISTS `fase` (
  `codiceFiscale` varchar(16) NOT NULL,
  `codicePratica` int(11) NOT NULL,
  `codicePrestazione` int(11) NOT NULL,
  `matricola` int(11) NOT NULL,
  `inizio` datetime NOT NULL,
  `fine` datetime NOT NULL,
  `descrizione` varchar(1024) NOT NULL,
  PRIMARY KEY (`matricola`,`codiceFiscale`,`codicePratica`,`codicePrestazione`,`inizio`),
  UNIQUE KEY `ID_FASE_IND` (`matricola`,`codiceFiscale`,`codicePratica`,`codicePrestazione`,`inizio`),
  KEY `FKsuddivisione_IND` (`codiceFiscale`,`codicePratica`,`codicePrestazione`)
) ;

--
-- Dump dei dati per la tabella `fase`
--

INSERT INTO `fase` (`codiceFiscale`, `codicePratica`, `codicePrestazione`, `matricola`, `inizio`, `fine`, `descrizione`) VALUES
('BNCGRG01S27I917O', 2, 6, 3, '2011-12-17 12:17:00', '2011-12-18 14:01:00', 'prova2'),
('BNCGRG01S27I917O', 2, 6, 3, '2018-06-05 00:00:00', '2018-06-06 00:01:00', 'vvvvv'),
('BNCGRG01S27I917O', 2, 7, 3, '2018-07-11 13:17:00', '2018-07-11 14:20:00', 'ifvnfedivj'),
('BNCGRG01S27I917O', 2, 6, 4, '2018-06-07 00:00:00', '2018-06-07 03:01:00', 'bbbbjhjnyh'),
('FRNMTN97P58E118M', 4, 9, 4, '2018-07-10 10:00:00', '2018-07-10 13:00:00', 'fase x'),
('FRNMTN97P58E118M', 4, 10, 4, '2018-07-10 10:00:00', '2018-07-10 13:00:00', 'fase x2');

--
-- Trigger `fase`
--
DROP TRIGGER IF EXISTS `TRIGGER_FASE_DURATA_AGGIORNAMENTO`;
DELIMITER $$
CREATE TRIGGER `TRIGGER_FASE_DURATA_AGGIORNAMENTO` AFTER UPDATE ON `fase` FOR EACH ROW BEGIN

UPDATE prestazione SET durata=SUBTIME(durata,TIMEDIFF(OLD.fine,OLD.inizio)) WHERE codiceFiscale=OLD.codiceFiscale AND codicePrestazione=OLD.codicePrestazione AND codicePratica=OLD.codicePratica;

UPDATE prestazione SET durata=ADDTIME(durata,TIMEDIFF(NEW.fine,NEW.inizio)) WHERE codiceFiscale=NEW.codiceFiscale AND codicePrestazione=NEW.codicePrestazione AND codicePratica=NEW.codicePratica;


END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `TRIGGER_FASE_DURATA_INSERIMENTO`;
DELIMITER $$
CREATE TRIGGER `TRIGGER_FASE_DURATA_INSERIMENTO` AFTER INSERT ON `fase` FOR EACH ROW BEGIN

UPDATE prestazione SET durata=ADDTIME(durata,TIMEDIFF(NEW.fine,NEW.inizio)) WHERE codiceFiscale=NEW.codiceFiscale AND codicePrestazione=NEW.codicePrestazione AND codicePratica=NEW.codicePratica;


END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `TRIGGER_FASE_SEDE`;
DELIMITER $$
CREATE TRIGGER `TRIGGER_FASE_SEDE` BEFORE INSERT ON `fase` FOR EACH ROW BEGIN
IF NOT EXISTS (SELECT * FROM cliente C WHERE C.codiceFiscale = new.codiceFiscale AND C.codiceSede IN (SELECT allocazione.codiceSede FROM allocazione WHERE allocazione.matricola = new.matricola)) THEN
	SIGNAL SQLSTATE '45001';
END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struttura della tabella `pratica`
--

DROP TABLE IF EXISTS `pratica`;
CREATE TABLE IF NOT EXISTS `pratica` (
  `codiceFiscale` varchar(16) NOT NULL,
  `codicePratica` int(11) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `dataRichiesta` date NOT NULL,
  PRIMARY KEY (`codiceFiscale`,`codicePratica`),
  UNIQUE KEY `ID_PRATICA_IND` (`codiceFiscale`,`codicePratica`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dump dei dati per la tabella `pratica`
--

INSERT INTO `pratica` (`codiceFiscale`, `codicePratica`, `nome`, `dataRichiesta`) VALUES
('BNCGRG01S27I917O', 0, 'aaaa', '2018-07-09'),
('BNCGRG01S27I917O', 2, 'Enim labore unde.\r\n', '2017-01-01'),
('BNCLSU02S08G837K', 9, 'Beatae molestias.\r\n', '2017-09-19'),
('BNCSFO03T26I604A', 7, 'Consequatur rerum.\r\n', '2017-08-05'),
('BNCSFO07E49B771A', 1, 'Delectus minima sint.', '2017-03-10'),
('FRNMTN97P58E118M', 4, 'Nostrum asperiores.', '2017-10-20'),
('FRNRRA07R44Z209Z', 5, 'Et ea sunt.\r\n', '2017-12-29'),
('FRNSLV98A64C547S', 6, 'Architecto officiis.\r\n', '2017-01-09'),
('FRNSRA97L08D103H', 8, 'Ratione similique.\r\n', '2017-07-09'),
('FRRGRG00R24B943H', 3, 'Voluptatem omnis;\r\n', '2017-10-14'),
('FRRNTN02A65A839O', 10, 'Ducimus est enim.', '2017-01-04');

--
-- Trigger `pratica`
--
DROP TRIGGER IF EXISTS `FIX_pratica_AUTO_INCREMENT`;
DELIMITER $$
CREATE TRIGGER `FIX_pratica_AUTO_INCREMENT` BEFORE INSERT ON `pratica` FOR EACH ROW BEGIN SET NEW.codicePratica = (SELECT IFNULL(MAX(codicePratica),0) + 1 FROM pratica WHERE pratica.codiceFiscale = NEW.codiceFiscale); END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struttura della tabella `prestazione`
--

DROP TABLE IF EXISTS `prestazione`;
CREATE TABLE IF NOT EXISTS `prestazione` (
  `codiceFiscale` varchar(16) NOT NULL,
  `codicePratica` int(11) NOT NULL,
  `codicePrestazione` int(11) NOT NULL,
  `compenso` float NOT NULL DEFAULT 0,
  `durata` time NOT NULL,
  `pagata` tinyint(1) NOT NULL,
  `terminata` tinyint(1) NOT NULL,
  `codiceSottocategoria` int(11) NOT NULL,
  PRIMARY KEY (`codiceFiscale`,`codicePratica`,`codicePrestazione`),
  UNIQUE KEY `ID_PRESTAZIONE_IND` (`codiceFiscale`,`codicePratica`,`codicePrestazione`),
  KEY `FKtipologia_IND` (`codiceSottocategoria`)
) ;

--
-- Dump dei dati per la tabella `prestazione`
--

INSERT INTO `prestazione` (`codiceFiscale`, `codicePratica`, `codicePrestazione`, `compenso`, `durata`, `pagata`, `terminata`, `codiceSottocategoria`) VALUES
('BNCGRG01S27I917O', 2, 5, 254, '00:00:00', 1, 1, 8),
('BNCGRG01S27I917O', 2, 6, 380, '51:46:00', 1, 1, 9),
('BNCGRG01S27I917O', 2, 7, 868, '01:03:00', 0, 1, 20),
('BNCGRG01S27I917O', 2, 100, 0, '00:00:00', 1, 1, 2),
('BNCLSU02S08G837K', 9, 10, 849, '00:00:00', 1, 0, 2),
('BNCLSU02S08G837K', 9, 11, 547, '00:00:00', 1, 1, 24),
('BNCLSU02S08G837K', 9, 12, 810, '00:00:00', 0, 0, 3),
('BNCMTN00D16C188G', 2, 101, 0, '00:00:00', 1, 1, 3),
('BNCSFO03T26I604A', 7, 6, 540, '00:00:00', 1, 1, 19),
('BNCSFO03T26I604A', 7, 7, 215, '00:00:00', 1, 1, 27),
('BNCSFO03T26I604A', 7, 8, 434, '00:00:00', 1, 0, 7),
('BNCSFO07E49B771A', 1, 3, 712, '00:00:00', 1, 0, 6),
('BNCSFO07E49B771A', 1, 4, 937, '00:00:00', 1, 0, 30),
('BNCSFO07E49B771A', 1, 5, 924, '00:00:00', 1, 1, 21),
('FRNMTN97P58E118M', 4, 9, 349, '03:00:00', 1, 1, 18),
('FRNMTN97P58E118M', 4, 10, 808, '03:00:00', 1, 0, 23),
('FRNMTN97P58E118M', 4, 11, 587, '00:00:00', 0, 1, 1),
('FRNRRA07R44Z209Z', 5, 2, 628, '00:00:00', 1, 1, 15),
('FRNRRA07R44Z209Z', 5, 3, 797, '00:10:00', 1, 0, 25),
('FRNRRA07R44Z209Z', 5, 4, 519, '00:00:00', 1, 0, 13),
('FRNSLV98A64C547S', 6, 4, 520, '00:00:00', 1, 1, 10),
('FRNSLV98A64C547S', 6, 5, 937, '00:00:00', 1, 1, 29),
('FRNSLV98A64C547S', 6, 6, 378, '00:00:00', 0, 1, 26),
('FRNSRA97L08D103H', 8, 8, 687, '00:00:00', 0, 0, 11),
('FRNSRA97L08D103H', 8, 9, 429, '00:00:00', 1, 1, 12),
('FRNSRA97L08D103H', 8, 10, 709, '00:00:00', 0, 1, 16),
('FRRGRG00R24B943H', 3, 7, 439, '00:00:00', 0, 1, 28),
('FRRGRG00R24B943H', 3, 8, 483, '00:00:00', 0, 1, 5),
('FRRGRG00R24B943H', 3, 9, 793, '00:00:00', 0, 1, 4),
('FRRNTN02A65A839O', 10, 1, 434, '00:00:00', 0, 1, 14),
('FRRNTN02A65A839O', 10, 2, 390, '00:00:00', 1, 0, 17),
('FRRNTN02A65A839O', 10, 3, 955, '02:04:00', 0, 1, 22);

--
-- Trigger `prestazione`
--
DROP TRIGGER IF EXISTS `FIX_prestazione_AUTO_INCREMENT`;
DELIMITER $$
CREATE TRIGGER `FIX_prestazione_AUTO_INCREMENT` BEFORE INSERT ON `prestazione` FOR EACH ROW BEGIN
SET NEW.codicePrestazione = (SELECT IFNULL(MAX(codicePrestazione),0) + 1 FROM prestazione WHERE prestazione.codicePratica = NEW.codicePratica AND prestazione.codiceFiscale = NEW.codiceFiscale);
END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `TRIGGER_PRESTAZIONE_SOTTOCATEGORIA`;
DELIMITER $$
CREATE TRIGGER `TRIGGER_PRESTAZIONE_SOTTOCATEGORIA` BEFORE INSERT ON `prestazione` FOR EACH ROW BEGIN

DECLARE TIPOCLIENTE CHAR;
DECLARE TIPOAZ INT;
DECLARE TIPOPF INT;

SET TIPOCLIENTE = (SELECT cliente.tipo FROM cliente WHERE cliente.codiceFiscale=new.codiceFiscale);
SET TIPOAZ = (SELECT sottocategoria.tipoAZ from sottocategoria where sottocategoria.codiceSottocategoria = new.codiceSottocategoria);
SET TIPOPF = (SELECT sottocategoria.tipoPF from sottocategoria where sottocategoria.codiceSottocategoria = new.codiceSottocategoria);

IF ((TIPOCLIENTE='A' AND TIPOAZ=0) OR (TIPOCLIENTE='P' AND TIPOPF=0)) THEN
	SIGNAL SQLSTATE '45001'; 
END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struttura della tabella `responsabile`
--

DROP TABLE IF EXISTS `responsabile`;
CREATE TABLE IF NOT EXISTS `responsabile` (
  `codiceFiscale` varchar(16) NOT NULL,
  `matricola` int(11) NOT NULL,
  `dataInizio` date NOT NULL,
  `dataFine` date DEFAULT NULL,
  PRIMARY KEY (`codiceFiscale`,`matricola`,`dataInizio`),
  UNIQUE KEY `ID_responsabile_IND` (`codiceFiscale`,`matricola`,`dataInizio`),
  KEY `FKattribuzione_IND` (`matricola`)
) ;

--
-- Dump dei dati per la tabella `responsabile`
--

INSERT INTO `responsabile` (`codiceFiscale`, `matricola`, `dataInizio`, `dataFine`) VALUES
('BNCRRA04L59L845V', 2, '2018-07-10', '2018-07-10'),
('BNCRRA04L59L845V', 4, '2018-07-10', NULL),
('LNGGLI05T50B847N', 2, '2018-06-11', '2018-06-14'),
('LNGGLI05T50B847N', 4, '2018-06-14', NULL),
('RSSNTN96D10D445N', 4, '2018-07-10', NULL);

--
-- Trigger `responsabile`
--
DROP TRIGGER IF EXISTS `TRIGGER_RESPONSABILE_SEDE`;
DELIMITER $$
CREATE TRIGGER `TRIGGER_RESPONSABILE_SEDE` BEFORE INSERT ON `responsabile` FOR EACH ROW BEGIN

 IF NOT EXISTS (SELECT * FROM cliente C WHERE C.codiceFiscale = 		  new.codiceFiscale AND C.codiceSede IN (SELECT allocazione.codiceSede FROM allocazione,dipendente WHERE dipendente.matricola=allocazione.matricola AND dipendente.tipo='I' AND allocazione.matricola = new.matricola)) THEN
        SIGNAL SQLSTATE '45001';
    END IF;

END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struttura della tabella `ruolo`
--

DROP TABLE IF EXISTS `ruolo`;
CREATE TABLE IF NOT EXISTS `ruolo` (
  `codiceRuolo` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(25) NOT NULL,
  PRIMARY KEY (`codiceRuolo`),
  UNIQUE KEY `ID_RUOLO_IND` (`codiceRuolo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dump dei dati per la tabella `ruolo`
--

INSERT INTO `ruolo` (`codiceRuolo`, `nome`) VALUES
(1, 'Impiegato'),
(2, 'Collaboratore'),
(3, 'Professionista'),
(4, 'Socio'),
(5, 'Segretario');

-- --------------------------------------------------------

--
-- Struttura della tabella `sede`
--

DROP TABLE IF EXISTS `sede`;
CREATE TABLE IF NOT EXISTS `sede` (
  `codiceSede` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(35) NOT NULL,
  `via` varchar(35) NOT NULL,
  `CAP` varchar(10) NOT NULL,
  `citta` varchar(34) NOT NULL,
  PRIMARY KEY (`codiceSede`),
  UNIQUE KEY `ID_SEDE_IND` (`codiceSede`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dump dei dati per la tabella `sede`
--

INSERT INTO `sede` (`codiceSede`, `nome`, `via`, `CAP`, `citta`) VALUES
(1, 'Studio BG Associati', 'via Roma 12', '61201', 'Urbino'),
(2, 'Studio GESA Pesaro', 'via Yuri Gagarin 67', '61122', 'Pesaro');

-- --------------------------------------------------------

--
-- Struttura della tabella `sottocategoria`
--

DROP TABLE IF EXISTS `sottocategoria`;
CREATE TABLE IF NOT EXISTS `sottocategoria` (
  `codiceSottocategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(120) NOT NULL,
  `descrizione` varchar(1024) NOT NULL,
  `costoFissoPerCliente` float NOT NULL DEFAULT 0,
  `tipoPF` tinyint(1) NOT NULL,
  `tipoAZ` tinyint(1) NOT NULL,
  `codiceCategoria` int(11) NOT NULL,
  PRIMARY KEY (`codiceSottocategoria`),
  UNIQUE KEY `ID_SOTTOCATEGORIA_IND` (`codiceSottocategoria`),
  KEY `FKspecializzazione_IND` (`codiceCategoria`)
) ;

--
-- Dump dei dati per la tabella `sottocategoria`
--

INSERT INTO `sottocategoria` (`codiceSottocategoria`, `nome`, `descrizione`, `costoFissoPerCliente`, `tipoPF`, `tipoAZ`, `codiceCategoria`) VALUES
(1, 'Contenzioso - Accesso breve Agenzia Entrate', '', 55, 1, 0, 1),
(2, 'Contenzioso - Accesso C.T.P', '', 67, 1, 0, 1),
(3, 'Contenzioso - Accesso C.T.R', '', 53, 0, 1, 1),
(4, 'Contenzioso - Assistenza accertamento con adesione', '', 76, 0, 1, 1),
(5, 'Contenzioso - Assistenza appello sentenza', '', 91, 0, 1, 1),
(6, 'Contenzioso - Assistenza avviso bonario', '', 77, 0, 1, 1),
(7, 'Contenzioso - Assistenza memoria', '', 72, 1, 0, 1),
(8, 'Contenzioso - Assistenza PVC', '', 85, 0, 1, 1),
(9, 'Contenzioso - Assistenza rateizzazione Agenzia Entrate', '', 73, 0, 1, 1),
(10, 'Contenzioso - Assistenza reclamo e mediazione', '', 81, 1, 0, 1),
(11, 'Contenzioso - Assistenza ricorso', '', 96, 0, 1, 1),
(12, 'Contenzioso - Accesso Agenzia Entrate', '', 90, 1, 0, 1),
(13, 'Contenzioso - Assistenza rateizzazione Equitalia', '', 91, 0, 1, 1),
(14, 'Contenzioso - Assistenza Equitalia', '', 71, 0, 1, 1),
(15, 'Contenzioso - Assistenza invito', '', 75, 1, 0, 1),
(16, 'Accesso CCIAA', '', 58, 1, 0, 2),
(17, 'Accesso Comune', '', 97, 1, 1, 2),
(18, 'Accesso Equitalia', '', 70, 0, 1, 2),
(19, 'Accesso INPS', '', 91, 1, 1, 2),
(20, 'Aggiornamento di studio', '', 87, 0, 1, 3),
(21, 'Aggiornamento professionale individuale', '', 81, 0, 1, 3),
(22, 'Aggiornamento software', '', 72, 1, 1, 3),
(23, 'Aggiornamento clienti - Circolari', '', 88, 0, 1, 3),
(24, 'Consulenza', '', 64, 0, 1, 4),
(25, 'Consulenza Tecnica di parte', '', 61, 1, 0, 4),
(26, 'Consulenza Tecnica di ufficio', '', 89, 0, 1, 4),
(27, 'Consulenza - Parere', '', 52, 0, 1, 4),
(28, 'Consulenza - Risposta quesito', '', 59, 0, 1, 4),
(29, 'Consulenza - Attestazione', '', 70, 0, 1, 4),
(30, 'Consulenza Procedura Concorsuale', '', 57, 0, 1, 4),
(31, 'Bilancio annuale - Elaborazione', '', 96, 1, 0, 5),
(32, 'Bilancio infrannuale - Elaborazione', '', 74, 0, 1, 5),
(33, 'Comunicazione - Beni e finananziamenti', '', 95, 1, 1, 6),
(34, 'Comunicazione - Intra acquisti', '', 81, 0, 1, 6),
(35, 'Comunicazione - Intra vendite', '', 83, 0, 1, 6),
(36, 'Comunicazione - Polivalente RSM', '', 75, 1, 1, 6),
(37, 'Comunicazione - Spesometro', '', 74, 0, 1, 6),
(38, 'Comunicazione - Liquididazione periodiche IVA', '', 98, 1, 1, 6),
(39, 'Comunicazione dati fatture', '', 77, 0, 1, 6),
(40, 'Dichiarazione - DR770', '', 75, 1, 1, 7),
(41, 'Dichiarazione - DRIRAP', '', 72, 1, 1, 7),
(42, 'Dichiarazione - DRIVA', '', 57, 0, 1, 7),
(43, 'Dichiarazione - DRUNICO', '', 72, 0, 1, 7),
(44, 'F24', '', 61, 1, 1, 7),
(45, 'Dichiarazione - Studio di settore', '', 57, 1, 1, 7),
(46, 'Dichiarazione - TR IVA', '', 94, 1, 1, 7),
(47, 'Dichiarazione - DRIVA visto conformitÃ ', '', 59, 0, 1, 7),
(48, 'Dichiarazione - DRUNICO visto conformitÃ ', '', 88, 1, 1, 7),
(49, 'Dichiarazione - TR IVA visto conformitÃ ', '', 60, 0, 1, 7),
(50, 'ContabilitÃ  - Inserimento dati IVA', '', 90, 0, 1, 8),
(51, 'ContabilitÃ  - Inserimento dati prima nota', '', 73, 0, 1, 8),
(52, 'Pratica CCIAA', '', 75, 1, 0, 9),
(53, 'Pratica Comune', '', 52, 0, 1, 9),
(54, 'Pratica ComunitÃ  Montana', '', 81, 0, 1, 9),
(55, 'Pratica Agenzia Entrate', '', 51, 0, 1, 9),
(56, 'Pratica INPS', '', 82, 0, 1, 9),
(57, 'W Pratica assunzione', '', 72, 0, 1, 9),
(58, 'W PRATICA LICENZIAMENTO', '', 93, 0, 1, 9),
(59, 'Pratica fattura elettronica', '', 75, 0, 1, 9),
(60, 'AttivitÃ  pro bono', '', 83, 0, 1, 10),
(61, 'AttivitÃ  istituzionale', '', 99, 1, 1, 10),
(62, 'AttivitÃ  varia', '', 78, 1, 0, 10),
(63, 'Carica Guardiano Trust', '', 52, 1, 1, 11),
(64, 'Carica Consigliere', '', 53, 0, 1, 11),
(65, 'Carica custodia giudiziaria', '', 75, 1, 0, 11),
(66, 'Carica Curatore', '', 58, 1, 0, 11),
(67, 'Carica Liquidatore giudiziale', '', 78, 0, 1, 11),
(68, 'Carica Commissario giudiziale', '', 72, 1, 0, 11),
(69, 'Carica Collegio Sindacale', '', 92, 0, 1, 11),
(70, 'Carica organismo composizione crisi', '', 58, 0, 1, 11),
(71, 'Stampe registri IVA', '', 71, 1, 0, 12),
(72, 'Stampe libro giornale', '', 85, 1, 1, 12),
(73, 'Stampe libro inventari', '', 79, 0, 1, 12),
(74, 'Stampe registro cespiti', '', 63, 0, 1, 12),
(75, 'Stampe libri sociali', '', 93, 1, 0, 12);

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `allocazione`
--
ALTER TABLE `allocazione`
  ADD CONSTRAINT `FKall_DIP_FK` FOREIGN KEY (`matricola`) REFERENCES `dipendente` (`matricola`),
  ADD CONSTRAINT `FKall_SED` FOREIGN KEY (`codiceSede`) REFERENCES `sede` (`codiceSede`);

--
-- Limiti per la tabella `cliente`
--
ALTER TABLE `cliente`
  ADD CONSTRAINT `FKservizio_FK` FOREIGN KEY (`codiceSede`) REFERENCES `sede` (`codiceSede`);

--
-- Limiti per la tabella `costo_struttura`
--
ALTER TABLE `costo_struttura`
  ADD CONSTRAINT `FKsalda_FK` FOREIGN KEY (`codiceSede`) REFERENCES `sede` (`codiceSede`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
