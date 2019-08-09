CREATE TABLE clan (
    jmbg_clana             CHAR(13) NOT NULL,
    ime              VARCHAR(50) NOT NULL,
    prezime          VARCHAR(50) NOT NULL,
    email            VARCHAR(50),
    datum_rodjenja   DATE,
    aktivan          bit NOT NULL
)

ALTER TABLE Clan ADD constraint clan_pk PRIMARY KEY CLUSTERED (jmbg_clana)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )


CREATE TABLE iznajmio (
    id_iznajmljivanja   INTEGER NOT NULL IDENTITY(1,1),
    jmbg_clana          CHAR(13) NOT NULL,
    id_knjige           INTEGER NOT NULL,
    datum_izdavanja     DATE NOT NULL,
    datum_vracanja      DATE NOT NULL,
    vracena             bit NOT NULL    
)

ALTER TABLE Iznajmio ADD constraint iznajmio_pk PRIMARY KEY CLUSTERED (id_iznajmljivanja)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )

CREATE TABLE knjiga (
    id_knjige               INTEGER NOT NULL IDENTITY(1,1),
    naziv_knjige            VARCHAR(100) NOT NULL,
    kolicina_u_biblioteci   INTEGER NOT NULL,
	jmbg_pisca				CHAR(13) NOT NULL,
    godina_izdavanja        INTEGER
)

ALTER TABLE Knjiga ADD constraint knjiga_pk PRIMARY KEY CLUSTERED (id_knjige)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
	 
CREATE TABLE pisac (
    jmbg_pisca             CHAR(13) NOT NULL,
    ime              VARCHAR(50) NOT NULL,
    prezime          VARCHAR(50) NOT NULL,
    datum_rodjenja   DATE
)

ALTER TABLE Pisac ADD constraint pisac_pk PRIMARY KEY CLUSTERED (jmbg_pisca)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )

ALTER TABLE Iznajmio
    ADD CONSTRAINT iznajmio_clan_fk FOREIGN KEY ( jmbg_clana )
        REFERENCES clan ( jmbg_clana )
		
ALTER TABLE Knjiga
    ADD CONSTRAINT napisao_knjigu_fk FOREIGN KEY ( jmbg_pisca )
        REFERENCES pisac ( jmbg_pisca )

ALTER TABLE Iznajmio
    ADD CONSTRAINT iznajmio_knjiga_fk FOREIGN KEY ( id_knjige )
        REFERENCES knjiga ( id_knjige )

CREATE TABLE korisnik (
	korisnicko_ime		VARCHAR(50) NOT NULL,
	lozinka				VARCHAR(50) NOT NULL,
)

-- Popunjavanje baze podataka sa vrednostima --

INSERT INTO korisnik VALUES ('admin', 'admin')
INSERT INTO korisnik VALUES ('nikola', 'nikola')

INSERT INTO clan VALUES (1234567890123, 'Aleksa', 'Bajat', 'aleksa.b@gmail.com', '2000-5-5', 1)
INSERT INTO clan VALUES (1234567890124, 'Nikola', 'Kuslakovic', 'nikola.k@gmail.com', '2002-2-15', 1)
INSERT INTO clan VALUES (1234567890125, 'Marko', 'Milicevic', 'marko.m@gmail.com', '2011-1-29', 1)
INSERT INTO clan VALUES (1234567890126, 'Relja', 'Radeka', 'relja.r@gmail.com', '2001-8-20', 1)

INSERT INTO pisac VALUES (1234567890990, 'Ivo', 'Andric', '1892-10-10')
INSERT INTO pisac VALUES (1234567890991, 'Lav', 'Tolostoj', '1828-9-9')
INSERT INTO pisac VALUES (1234567890992, 'Danilo', 'Kis', '1935-2-22')
INSERT INTO pisac VALUES (1234567890993, 'Aleksandar', 'Puskin', '1799-5-26')
INSERT INTO pisac VALUES (1234567890994, 'Desanka', 'Maksimovic', '1898-5-16')

INSERT INTO knjiga VALUES ('Na Drini cuprija', 8, 1234567890990, 2000)
INSERT INTO knjiga VALUES ('Prokleta avlija', 5, 1234567890990, 1997)
INSERT INTO knjiga VALUES ('Ana Karenjina', 1, 1234567890991, 1999)
INSERT INTO knjiga VALUES ('Rat i mir', 5, 1234567890991, 2000)
INSERT INTO knjiga VALUES ('Rani jadi', 2, 1234567890992, 2009)
INSERT INTO knjiga VALUES ('Evgenije Onjegin', 5, 1234567890993, 1990)
INSERT INTO knjiga VALUES ('Pamticu sve', 3, 1234567890994, 2010)
