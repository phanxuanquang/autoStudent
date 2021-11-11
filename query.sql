CREATE TABLE Type (
    [Id_Type] INT NOT NULL PRIMARY KEY,
    [Type] VARCHAR (50) NULL
)
CREATE TABLE Application (
    [Id_Software] INT NOT NULL PRIMARY KEY,
    [Name]        VARCHAR (50)   NULL,
    [Link]        VARCHAR (1000) NULL,
  	[WindowsName] VARCHAR(100)   NULL,
    [Version]     VARCHAR (4)    NULL,
    [Extension]        VARCHAR (10)   NULL,
    [Id_Type]     INT            NULL,
    CONSTRAINT FK_TYPE_APPLICATION FOREIGN KEY ([Id_Type]) REFERENCES Type([Id_Type])
)
CREATE TABLE Install (
    [Id]             INT           NOT NULL,
    [Id_Software]    INT           NOT NULL,
  	[KeyPress]	VARCHAR(10) NULL,
    [Thread_Sleep]   INT           DEFAULT ((100)) NULL,
    CONSTRAINT PK_ID_ID_SOFTWARE PRIMARY KEY([Id],[Id_Software]),
    CONSTRAINT FK_INSTALL_APPLICATION FOREIGN KEY ([Id_Software]) REFERENCES Application([Id_Software])
)

INSERT INTO Type VALUES (1, 'Tech')
INSERT INTO Type VALUES (2, 'IT')
INSERT INTO Type VALUES (3, 'Design')

INSERT INTO Application VALUES (1,'VSCode','https://windows','Setup - Visual Code','x64','exe',2)

INSERT INTO Install VALUES (1,1,'TAB', 50)
INSERT INTO Install VALUES (2,1,'UP', 50)
INSERT INTO Install VALUES (3,1,'ENTER', 50)
INSERT INTO Install VALUES (4,1,'ENTER', 50)
INSERT INTO Install VALUES (5,1,'ENTER', 50)
INSERT INTO Install VALUES (6,1,'ENTER', 50)
INSERT INTO Install VALUES (7,1,'ENTER', 50)
INSERT INTO Install VALUES (8,1,'TAB', 16000)
INSERT INTO Install VALUES (9,1,'TAB', 50)
INSERT INTO Install VALUES (10,1,'SPACE', 50)
INSERT INTO Install VALUES (11,1,'ENTER', 50)