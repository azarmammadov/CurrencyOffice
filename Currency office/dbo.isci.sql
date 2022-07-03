CREATE TABLE [dbo].[isci] (
    [ID]               INT  NOT NULL,
    [Ad]               NVARCHAR(50) NULL,
    [Soyad]            NVARCHAR(50) NULL,
    [AtaAdi]           NVARCHAR(50) NULL,
    [Unvan]            NVARCHAR(50) NULL,
    [DogumYeri]        NVARCHAR(50) NULL,
    [DogumGunu]        NVARCHAR(50) NULL,
    [IsTecrubesi]      INT  NULL,
    [TehsilMuessisesi] NVARCHAR(50) NULL,
    [Ixtisasi]         NVARCHAR(50) NULL,
    [Vezifesi]         NVARCHAR(50) NULL,
    [MaasiManatla]     INT  NULL,
    [IstifadeciAdi]    NVARCHAR(50) NULL,
    [Sifre]            NVARCHAR(50) NULL,
    [FinKod] NVARCHAR(50) NULL, 
    [SeriyaNom] NVARCHAR(50) NULL, 
    [TelefonNomresi] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_isci] PRIMARY KEY CLUSTERED ([ID] ASC)
);

