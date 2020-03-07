CREATE TABLE [dbo].[Subcomenzi] (
    [id_subcomanda] INT          IDENTITY (1, 1) NOT NULL,
    [id_comanda]    INT NULL,
    [id_produs]     INT          NULL,
    [cantitate]     INT          NULL,
    CONSTRAINT [PK_Subcomenzi] PRIMARY KEY CLUSTERED ([id_subcomanda] ASC)
);

