-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 05-Fev-2023 às 02:01
-- Versão do servidor: 5.7.17
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bd_fisioterapia`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `paciente`
--

CREATE TABLE `paciente` (
  `cod_pac` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `idade` varchar(10) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `celular` varchar(15) NOT NULL,
  `email` varchar(50) NOT NULL,
  `data_nasc` date NOT NULL,
  `ind_clinica` varchar(200) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `paciente`
--

INSERT INTO `paciente` (`cod_pac`, `nome`, `idade`, `cpf`, `endereco`, `celular`, `email`, `data_nasc`, `ind_clinica`) VALUES
(10, 'Adriana Cunha', '17', '12554788569', 'Estrada do Guanumbi 630', '21994830586', 'dri.cunha@gmail.com', '2023-02-04', 'Desvio de postura'),
(9, 'Julio Cesar', '48', '02014564750', 'Estrada dos tres rios 1395', '21982228206', 'juliogea@gmail.com', '1975-09-11', 'Dor intensa no joelho');

-- --------------------------------------------------------

--
-- Estrutura da tabela `profissional`
--

CREATE TABLE `profissional` (
  `cod_prof` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `crefito` varchar(6) NOT NULL,
  `celular` varchar(15) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `profissional`
--

INSERT INTO `profissional` (`cod_prof`, `nome`, `cpf`, `crefito`, `celular`) VALUES
(8, 'Marilene Castro', '02048765980', '24578F', '21981649098'),
(9, 'Debora Silva', '56321487795', '58945A', '21994509295');

-- --------------------------------------------------------

--
-- Estrutura da tabela `servico`
--

CREATE TABLE `servico` (
  `cod_serv` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `valor` float NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `quantidade_de_sessoes` int(11) NOT NULL,
  `segunda` varchar(20) NOT NULL,
  `terca` varchar(20) NOT NULL,
  `quarta` varchar(20) NOT NULL,
  `quinta` varchar(20) NOT NULL,
  `sexta` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `servico`
--

INSERT INTO `servico` (`cod_serv`, `nome`, `valor`, `tipo`, `quantidade_de_sessoes`, `segunda`, `terca`, `quarta`, `quinta`, `sexta`) VALUES
(14, 'Fisioterapia - 5 sessões', 750, 'Motora', 5, 'sim', 'sim', 'sim', 'sim', 'sim'),
(13, 'Fisioterapia - 10 sessões', 1200, 'Motora', 10, 'sim', 'sim', 'sim', 'sim', 'sim');

-- --------------------------------------------------------

--
-- Estrutura da tabela `sessao`
--

CREATE TABLE `sessao` (
  `cod_sessao` int(11) NOT NULL,
  `cod_pac` int(11) NOT NULL,
  `cod_prof` int(11) NOT NULL,
  `cod_serv` int(11) NOT NULL,
  `forma_pagamento` varchar(30) NOT NULL,
  `data_sessao` date NOT NULL,
  `observacao` varchar(200) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `sessao`
--

INSERT INTO `sessao` (`cod_sessao`, `cod_pac`, `cod_prof`, `cod_serv`, `forma_pagamento`, `data_sessao`, `observacao`) VALUES
(24, 9, 8, 13, 'Cartão de Débito', '2023-01-26', 'sem criatividade'),
(25, 9, 8, 13, 'Dinheiro', '2023-02-03', 'sem criatividade'),
(23, 9, 9, 13, 'Cartão de Débito', '2023-01-25', 'sem criatividade'),
(16, 10, 9, 14, 'Pix', '2023-02-03', 'Finalização do tratamento, paciente realinhou a o desvio postural'),
(17, 10, 8, 14, 'Pix', '2023-01-31', 'Uso dos equipamentos amarelos'),
(18, 10, 8, 14, 'Pix', '2023-02-01', 'Realização de diversos alongamentos'),
(19, 10, 8, 14, 'Pix', '2023-02-02', 'Trabalho no tatame'),
(20, 10, 9, 14, 'Pix', '2023-02-03', 'Finalização do tratamento, paciente realinhou a postura'),
(21, 9, 9, 13, 'Cartão de Débito', '2023-01-23', 'trabalho apertando a bola laranja'),
(22, 9, 8, 13, 'Cartão de Débito', '2023-01-24', 'sem criatividade'),
(26, 9, 9, 13, 'Dinheiro', '2023-01-30', 'sem criatividade'),
(27, 9, 9, 13, 'Dinheiro', '2023-01-31', 'sem criatividade'),
(28, 9, 9, 13, 'Dinheiro', '2023-02-01', 'sem criatividade'),
(29, 9, 9, 13, 'Dinheiro', '2023-02-02', 'sem criatividade');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `paciente`
--
ALTER TABLE `paciente`
  ADD PRIMARY KEY (`cod_pac`);

--
-- Indexes for table `profissional`
--
ALTER TABLE `profissional`
  ADD PRIMARY KEY (`cod_prof`);

--
-- Indexes for table `servico`
--
ALTER TABLE `servico`
  ADD PRIMARY KEY (`cod_serv`);

--
-- Indexes for table `sessao`
--
ALTER TABLE `sessao`
  ADD PRIMARY KEY (`cod_sessao`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `paciente`
--
ALTER TABLE `paciente`
  MODIFY `cod_pac` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `profissional`
--
ALTER TABLE `profissional`
  MODIFY `cod_prof` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `servico`
--
ALTER TABLE `servico`
  MODIFY `cod_serv` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `sessao`
--
ALTER TABLE `sessao`
  MODIFY `cod_sessao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
