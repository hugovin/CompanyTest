

USE [RuleTest]
GO
/****** Object:  Table [dbo].[massinsert]    Script Date: 06/03/2014 00:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[massinsert](
	[id_mass] [int] IDENTITY(1,1) NOT NULL,
	[shape] [nvarchar](100) NULL,
	[is_valid] [tinyint] NULL,
 CONSTRAINT [PK_massinsert] PRIMARY KEY CLUSTERED 
(
	[id_mass] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[shapes]    Script Date: 06/03/2014 00:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[shapes](
	[id_shape] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](20) NOT NULL,
	[coordinates] [varchar](50) NOT NULL,
	[area] [float] NOT NULL,
	[date_created] [datetime] NOT NULL,
	[is_valid] [tinyint] NOT NULL,
 CONSTRAINT [PK_shapes] PRIMARY KEY CLUSTERED 
(
	[id_shape] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[MassUpdate]    Script Date: 06/03/2014 00:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hugo Vindas
-- Create date: 03/06/2014
-- Description:	Upload The file to the DB
-- =============================================
CREATE PROCEDURE [dbo].[MassUpdate]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

BULK
   INSERT massinsert from 'c:\massinsert.csv'
WITH
(
    FIELDTERMINATOR = ';',
    ROWTERMINATOR = '\n'
)
END
GO
