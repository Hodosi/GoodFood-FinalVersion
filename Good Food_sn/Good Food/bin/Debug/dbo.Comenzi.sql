CREATE TABLE [dbo].[Comenzi] (
    [id_comanda]   INT NOT NULL IDENTITY,
    [id_client]    INT          NULL,
    [data_comanda] DATETIME     NULL,
    CONSTRAINT [PK_Comenzi] PRIMARY KEY CLUSTERED ([id_comanda] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Comenzi', @level2type = N'COLUMN', @level2name = N'data_comanda';

