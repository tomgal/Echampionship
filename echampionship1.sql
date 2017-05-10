-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Mer 10 Mai 2017 à 08:22
-- Version du serveur :  5.7.14
-- Version de PHP :  5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `echampionship1`
--

-- --------------------------------------------------------

--
-- Structure de la table `classement`
--

CREATE TABLE `classement` (
  `idClassement` int(11) NOT NULL,
  `Libellé` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `classereq`
--

CREATE TABLE `classereq` (
  `IdClass` int(11) NOT NULL,
  `IdEquipe` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `classeruser`
--

CREATE TABLE `classeruser` (
  `IdClass` int(11) NOT NULL,
  `IdUser` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `concerne`
--

CREATE TABLE `concerne` (
  `IdJeux` int(11) NOT NULL,
  `IdTournois` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

CREATE TABLE `contenir` (
  `IdUser` int(11) NOT NULL,
  `IdEquipe` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `equipe`
--

CREATE TABLE `equipe` (
  `IdEquipe` int(11) NOT NULL,
  `NomEquipe` varchar(20) NOT NULL,
  `ClassEquipe` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `jeux`
--

CREATE TABLE `jeux` (
  `IdJeux` int(11) NOT NULL,
  `NomJeux` varchar(40) NOT NULL,
  `Image_Url` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `jeux`
--

INSERT INTO `jeux` (`IdJeux`, `NomJeux`, `Image_Url`) VALUES
(1, 'Overwatch', 'Images/Overwatch.jpg'),
(2, 'League of Legends', 'Images/LeagueOfLegends.jpg'),
(3, 'Starcraft 2', 'Images/Starcraft2.jpg'),
(4, 'Counter Strike : Global Offensive', 'Images/CSGO.jpg'),
(5, 'WoW', 'Images/WOW.jpg'),
(6, 'FiFa 17', 'Images/Fifa17.jpg'),
(7, 'HearthStone', 'Images/Hearthstone.jpg'),
(8, 'Dota 2', 'Images/Dota2.jpg');

-- --------------------------------------------------------

--
-- Structure de la table `jouer`
--

CREATE TABLE `jouer` (
  `IdUser` int(11) NOT NULL,
  `IdJeux` int(11) NOT NULL,
  `level` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `jouer`
--

INSERT INTO `jouer` (`IdUser`, `IdJeux`, `level`) VALUES
(19, 0, ''),
(20, 4, ''),
(20, 5, ''),
(20, 6, ''),
(72, 2, ''),
(72, 4, ''),
(72, 7, ''),
(72, 1, ''),
(73, 1, ''),
(73, 2, ''),
(73, 4, ''),
(73, 7, ''),
(74, 1, ''),
(74, 4, ''),
(74, 2, '');

-- --------------------------------------------------------

--
-- Structure de la table `pari`
--

CREATE TABLE `pari` (
  `id_pari` int(11) NOT NULL,
  `id_jeux` int(11) NOT NULL,
  `id_equipe1` int(11) NOT NULL,
  `id_equipe2` int(11) NOT NULL,
  `cote_equipe1` double NOT NULL,
  `cote_equipe2` double NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `pari`
--

INSERT INTO `pari` (`id_pari`, `id_jeux`, `id_equipe1`, `id_equipe2`, `cote_equipe1`, `cote_equipe2`) VALUES
(1, 2, 1, 2, 3.25, 1.55),
(2, 2, 1, 2, 1.8, 3.6);

-- --------------------------------------------------------

--
-- Structure de la table `participation`
--

CREATE TABLE `participation` (
  `IdParticipation` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `participer`
--

CREATE TABLE `participer` (
  `IdEquipe` int(11) NOT NULL,
  `IdTournois` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `professionnel`
--

CREATE TABLE `professionnel` (
  `Id_equipe_pro` int(11) NOT NULL,
  `id_jeu` int(11) NOT NULL,
  `Nom_Equipe` varchar(50) NOT NULL,
  `Logo_Equipe` longtext NOT NULL,
  `Nation_Equipe` varchar(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `professionnel`
--

INSERT INTO `professionnel` (`Id_equipe_pro`, `id_jeu`, `Nom_Equipe`, `Logo_Equipe`, `Nation_Equipe`) VALUES
(1, 2, 'Fnatic', 'https://s3.amazonaws.com/battlefy-user-generated-assets/users/5705136068a5b07b12354385/57051764e2d67f7f12adbaf4.png', 'EU'),
(2, 2, 'SKT T1', 'https://cdn0.vox-cdn.com/thumbor/ouyzB0uyVrXfppzQ-O2rhf8RX3Q=/800x0/filters:no_upscale()/cdn0.vox-cdn.com/uploads/chorus_asset/file/7817619/lpbyMiQ.png', 'Corea');

-- --------------------------------------------------------

--
-- Structure de la table `tournois`
--

CREATE TABLE `tournois` (
  `IdTournois` int(11) NOT NULL,
  `NomTournois` varchar(40) NOT NULL,
  `Date` date NOT NULL,
  `Niveau` varchar(20) NOT NULL,
  `id_jeu` int(11) NOT NULL,
  `nbPlace` int(11) NOT NULL,
  `createur` varchar(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `tournois`
--

INSERT INTO `tournois` (`IdTournois`, `NomTournois`, `Date`, `Niveau`, `id_jeu`, `nbPlace`, `createur`) VALUES
(1, 'Overwatch League', '2017-04-20', 'Low - / Medium -', 1, 64, 'admin'),
(2, 'Leagues Of Legends League', '2017-04-28', 'Medium - / High -', 2, 32, 'admin');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
  `IdUser` int(11) NOT NULL,
  `Pseudo` varchar(20) DEFAULT ' ',
  `Password` varchar(100) NOT NULL,
  `Mail` varchar(30) NOT NULL,
  `NomUser` varchar(20) DEFAULT ' ',
  `Prenom` varchar(20) DEFAULT ' ',
  `PseudoSteam` varchar(30) DEFAULT ' ',
  `PseudoLol` varchar(30) DEFAULT ' ',
  `PseudoBattleNet` varchar(30) DEFAULT '',
  `Crédits` int(11) NOT NULL DEFAULT '0',
  `connect` int(11) NOT NULL DEFAULT '0',
  `PseudoOrigin` varchar(50) DEFAULT ' ',
  `UrlPhotoProfil` varchar(50) DEFAULT '""'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `user`
--

INSERT INTO `user` (`IdUser`, `Pseudo`, `Password`, `Mail`, `NomUser`, `Prenom`, `PseudoSteam`, `PseudoLol`, `PseudoBattleNet`, `Crédits`, `connect`, `PseudoOrigin`, `UrlPhotoProfil`) VALUES
(76, 'tomgal', 'marseille13', 'sio.galibert@gmail.com', 'galibert', 'thomas', 'omg_sissou', 'Omg 6sou', 'Fleuuuur#2445', 1200, 0, ' ', '/Images/tomgal_profil.jpg'),
(77, 'aaa', '89ae2807eb7bb147cd37268e298edd9d', 'aaa@gmail.com', ' ', ' ', ' ', ' ', '', 0, 0, ' ', '""'),
(78, 'aaaa', '89ae2807eb7bb147cd37268e298edd9d', 'Aaaa@gmail.com', ' ', ' ', ' ', ' ', '', 0, 0, ' ', '""'),
(79, 'Cheepyy', '216ac8e16f5490b066f1809f7e433e0c', 'alexandre.99@hotmail.fr', ' ', ' ', ' ', ' ', '', 0, 0, ' ', '""'),
(80, 'Azer', '89ae2807eb7bb147cd37268e298edd9d', 'Azer@gmail.com', ' ', ' ', ' ', ' ', '', 0, 0, ' ', '""');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `classement`
--
ALTER TABLE `classement`
  ADD PRIMARY KEY (`idClassement`);

--
-- Index pour la table `classereq`
--
ALTER TABLE `classereq`
  ADD PRIMARY KEY (`IdClass`,`IdEquipe`),
  ADD KEY `IdEquipe` (`IdEquipe`);

--
-- Index pour la table `classeruser`
--
ALTER TABLE `classeruser`
  ADD PRIMARY KEY (`IdClass`,`IdUser`);

--
-- Index pour la table `concerne`
--
ALTER TABLE `concerne`
  ADD PRIMARY KEY (`IdJeux`,`IdTournois`),
  ADD KEY `IdTournois` (`IdTournois`);

--
-- Index pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD PRIMARY KEY (`IdUser`,`IdEquipe`),
  ADD KEY `IdEquipe` (`IdEquipe`);

--
-- Index pour la table `equipe`
--
ALTER TABLE `equipe`
  ADD PRIMARY KEY (`IdEquipe`);

--
-- Index pour la table `jeux`
--
ALTER TABLE `jeux`
  ADD PRIMARY KEY (`IdJeux`);

--
-- Index pour la table `jouer`
--
ALTER TABLE `jouer`
  ADD PRIMARY KEY (`IdUser`,`IdJeux`),
  ADD KEY `IdJeux` (`IdJeux`);

--
-- Index pour la table `pari`
--
ALTER TABLE `pari`
  ADD PRIMARY KEY (`id_pari`);

--
-- Index pour la table `participer`
--
ALTER TABLE `participer`
  ADD PRIMARY KEY (`IdEquipe`,`IdTournois`),
  ADD KEY `IdTournois` (`IdTournois`);

--
-- Index pour la table `professionnel`
--
ALTER TABLE `professionnel`
  ADD PRIMARY KEY (`Id_equipe_pro`);

--
-- Index pour la table `tournois`
--
ALTER TABLE `tournois`
  ADD PRIMARY KEY (`IdTournois`);

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`IdUser`),
  ADD UNIQUE KEY `Pseudo` (`Pseudo`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `classement`
--
ALTER TABLE `classement`
  MODIFY `idClassement` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `equipe`
--
ALTER TABLE `equipe`
  MODIFY `IdEquipe` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `jeux`
--
ALTER TABLE `jeux`
  MODIFY `IdJeux` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT pour la table `pari`
--
ALTER TABLE `pari`
  MODIFY `id_pari` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `professionnel`
--
ALTER TABLE `professionnel`
  MODIFY `Id_equipe_pro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `tournois`
--
ALTER TABLE `tournois`
  MODIFY `IdTournois` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `IdUser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
