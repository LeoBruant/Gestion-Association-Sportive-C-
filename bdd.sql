
-- Recharger la DB!

-- On se positionne sur la base GestionAssociationSportive pour insérer les tables
USE GestionAssociationSportive;

-- Table UTILISATEUR
CREATE TABLE UTILISATEUR (
	Id_utilisateur int NOT NULL IDENTITY (1, 1),
	Login_utilisateur varchar(255) NOT NULL,
	Mdp_utilisateur varchar(255) NOT NULL,
	Droit_utilisateur tinyint NOT NULL,

	CONSTRAINT Id_utilisateur PRIMARY KEY NONCLUSTERED (Id_utilisateur),
);

-- Table CLASSE
CREATE TABLE CLASSE (
	Id_classe int NOT NULL IDENTITY (1, 1),
	Libelle_classe varchar(255) NOT NULL,

	CONSTRAINT Id_classe PRIMARY KEY NONCLUSTERED (Id_classe),
);

-- Table ADHERENT
CREATE TABLE ADHERENT (
	Id_adherent int NOT NULL IDENTITY (1, 1),
	Nom_adherent varchar(255) NOT NULL,
	Prenom_adherent varchar(255) NOT NULL,
	Ddn_adherent date NOT NULL,
	Numtel_adherent varchar(255) NOT NULL,
	Email_adherent varchar(255) NOT NULL,
	Numparent_adherent varchar(255) NULL,
	Autprelev_adherent tinyint NOT NULL,
	Sexe_adherent varchar(255) NOT NULL,
	Login_adherent varchar(255) NOT NULL,
	Mdp_adherent varchar(255) NOT NULL,
	Datemaj_adherent date NOT NULL,
	Archive_adherent tinyint NOT NULL,
	Prend_sweat tinyint NOT NULL,
	#Id_classe int NOT NULL,

	CONSTRAINT Id_adherent PRIMARY KEY NONCLUSTERED (Id_adherent),

	CONSTRAINT Id_classe_adherent FOREIGN KEY (#Id_classe)
        REFERENCES CLASSE (Id_classe)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
);

-- Table BUDGET
CREATE TABLE BUDGET (
	Id_budget int NOT NULL IDENTITY (1, 1),
	Libelle_budget varchar(255) NOT NULL,
	Montantinitial_budget float NOT NULL,

	CONSTRAINT Id_budget PRIMARY KEY NONCLUSTERED (Id_budget),
);

-- Table TYPE_FLUX
CREATE TABLE TYPE_FLUX (
	Id_typeflux int NOT NULL IDENTITY (1, 1),
	Libelle_typeflux varchar(255) NOT NULL,

	CONSTRAINT Id_typeflux PRIMARY KEY NONCLUSTERED (Id_typeflux),
);

-- Table EVENEMENT
CREATE TABLE EVENEMENT (
	Id_evenement int NOT NULL IDENTITY (1, 1),
	Libelle_evenement varchar(255) NOT NULL,
	Date_evenement date NOT NULL,
	Lieu_evenement varchar(255) NOT NULL,
	Cout_evenement float NOT NULL,

	CONSTRAINT Id_evenement PRIMARY KEY NONCLUSTERED (Id_evenement),
);

-- Table FLUX
CREATE TABLE FLUX (
	Id_flux int NOT NULL IDENTITY (1, 1),
	Libelle_flux varchar(255) NOT NULL,
	Date_flux date NOT NULL,
	Montant_flux float NOT NULL,
	Prelevementeff_flux tinyint,
	#Id_adherent int NOT NULL,
	#Id_typeflux int NOT NULL,
	#Id_evenement int NOT NULL,
	#Id_budget int NOT NULL,

	CONSTRAINT Id_flux PRIMARY KEY NONCLUSTERED (Id_flux),

	CONSTRAINT Id_adherent_flux FOREIGN KEY (#Id_adherent)
        REFERENCES ADHERENT (Id_adherent)
        ON DELETE CASCADE
        ON UPDATE CASCADE,

	CONSTRAINT Id_typeflux_flux FOREIGN KEY (#Id_typeflux)
        REFERENCES TYPE_FLUX (Id_typeflux)
        ON DELETE CASCADE
        ON UPDATE CASCADE,

	CONSTRAINT Id_evenement_flux FOREIGN KEY (#Id_evenement)
        REFERENCES EVENEMENT (Id_evenement)
        ON DELETE CASCADE
        ON UPDATE CASCADE,

	CONSTRAINT Id_budget_flux FOREIGN KEY (#Id_budget)
        REFERENCES BUDGET (Id_budget)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
);

-- On exécute le script
GO

-- Recharger la DB!