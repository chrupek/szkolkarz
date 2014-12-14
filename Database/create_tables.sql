USE [szkolkarz]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ADM_ARTICLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ARTICLE] [nvarchar](100) NOT NULL,
	[YEAR] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_ADM_ARTICLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_ADM_ARTICLE] UNIQUE NONCLUSTERED 
(
	[ARTICLE] ASC,
	[YEAR] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[ADM_CERTIFICATE](
	[ID] [int] NOT NULL IDENTITY (1,1),
	[CERTIFICATE] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_ADM_CERTIFICATE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[ADM_CERTIFICATE_ARTICLE_REF](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ADM_CERTIFICATE_ID] [int] NOT NULL,
	[ADM_ARTICLE_ID] [int] NOT NULL,
 CONSTRAINT [PK_ADM_CERTIFICATE_ARTICLE_REF] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ADM_CERTIFICATE_ARTICLE_REF]  WITH CHECK ADD  CONSTRAINT [FK_ADM_CERTIFICATE_ARTICLE_REF_ADM_CERTIFICATE] FOREIGN KEY([ADM_CERTIFICATE_ID])
REFERENCES [dbo].[ADM_CERTIFICATE] ([ID])
GO

ALTER TABLE [dbo].[ADM_CERTIFICATE_ARTICLE_REF] CHECK CONSTRAINT [FK_ADM_CERTIFICATE_ARTICLE_REF_ADM_CERTIFICATE]
GO

ALTER TABLE [dbo].[ADM_CERTIFICATE_ARTICLE_REF]  WITH CHECK ADD  CONSTRAINT [FK_ADM_CERTIFICATE_ARTICLE_REF_ADM_CERTIFICATE_ARTICLE_REF] FOREIGN KEY([ADM_ARTICLE_ID])
REFERENCES [dbo].[ADM_CERTIFICATE_ARTICLE_REF] ([ID])
GO

ALTER TABLE [dbo].[ADM_CERTIFICATE_ARTICLE_REF] CHECK CONSTRAINT [FK_ADM_CERTIFICATE_ARTICLE_REF_ADM_CERTIFICATE_ARTICLE_REF]
GO

CREATE TABLE [dbo].[ADM_SOWN_LOG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TAPE_ID] [int] NOT NULL,
	[ADM_CERTIFICATE_ARTICLE_REF_ID] [int] NOT NULL,
 CONSTRAINT [PK_ADM_SOWN_LOG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

 CONSTRAINT [IX_ADM_SOWN_LOG] UNIQUE NONCLUSTERED 
(
	[TAPE_ID] ASC,
	[ADM_CERTIFICATE_ARTICLE_REF_ID] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ADM_SOWN_LOG]  WITH CHECK ADD  CONSTRAINT [FK_ADM_SOWN_LOG_ADM_CERTIFICATE_ARTICLE_REF] FOREIGN KEY([ADM_CERTIFICATE_ARTICLE_REF_ID])
REFERENCES [dbo].[ADM_CERTIFICATE_ARTICLE_REF] ([ID])
GO

ALTER TABLE [dbo].[ADM_SOWN_LOG] CHECK CONSTRAINT [FK_ADM_SOWN_LOG_ADM_CERTIFICATE_ARTICLE_REF]
GO

ALTER TABLE [dbo].[ADM_SOWN_LOG]  WITH CHECK ADD  CONSTRAINT [FK_ADM_SOWN_LOG_ADM_CERTIFICATE_ARTICLE_REF_ID] FOREIGN KEY([ADM_CERTIFICATE_ARTICLE_REF_ID])
REFERENCES [dbo].[ADM_CERTIFICATE_ARTICLE_REF] ([ID])
GO

ALTER TABLE [dbo].[ADM_SOWN_LOG] CHECK CONSTRAINT [FK_ADM_SOWN_LOG_ADM_CERTIFICATE_ARTICLE_REF_ID]
GO

CREATE TABLE [dbo].[SEC_AUDIT_LOG](
	[ID] [int] NOT NULL,
	[USER] [nvarchar](100) NOT NULL,
	[ACTION] [nvarchar](50) NOT NULL,
	[MESSAGE] [nvarchar](max) NOT NULL,
	[TIME_STAMP] [timestamp] NOT NULL,
 CONSTRAINT [PK_AUDIT_LOG_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

CREATE TABLE [dbo].[SEC_ERROR_LOG](
	[ID] [int] NOT NULL,
	[USER] [nvarchar](100) NOT NULL,
	[MESSAGE] [nvarchar](max) NOT NULL,
	[TIME_STAMP] [timestamp] NOT NULL,
 CONSTRAINT [PK_SEC_ERROR_LOG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[TIME_STAMP] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


