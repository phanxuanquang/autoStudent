CREATE TABLE Type (
    [Id_Type] INT NOT NULL PRIMARY KEY,
    [Type] VARCHAR (50) NULL
)
CREATE TABLE Application (
    [Id_Software] INT NOT NULL PRIMARY KEY,
    [Name]        VARCHAR (50)   NULL,
    [Link]        VARCHAR (1000) NULL,
    [Version]     VARCHAR (4)    NULL,
    [Type]        VARCHAR (10)   NULL,
    [Id_Type]     INT            NULL,
    CONSTRAINT FK_TYPE_APPLICATION FOREIGN KEY ([Id_Type]) REFERENCES Type([Id_Type])
)
CREATE TABLE InstallStatus (
    [Id_Software] INT NOT NULL PRIMARY KEY,
    [Succeeded]   VARCHAR (50) NULL,
    [Failed]      VARCHAR (50) NULL,
    CONSTRAINT FK_InstallStatus_Install FOREIGN KEY ([Id_Software]) REFERENCES Application([Id_Software])
)
CREATE TABLE Install (
    [Id]             INT           NOT NULL,
    [Id_Software]    INT           NOT NULL,
    [Control_Class]  VARCHAR (100) NULL,
    [Control_Text]   VARCHAR (100) NULL,
    [Control_ID]     INT           NULL,
    [Mouse_Position] VARCHAR (20)  NULL,
    [Thread_Sleep]   INT           DEFAULT ((100)) NULL,
    CONSTRAINT PK_ID_ID_SOFTWARE PRIMARY KEY([Id],[Id_Software]),
    CONSTRAINT FK_INSTALL_APPLICATION FOREIGN KEY ([Id_Software]) REFERENCES Application([Id_Software])
)

INSERT INTO Type VALUES (1, 'Tech')
INSERT INTO Type VALUES (2, 'IT')
INSERT INTO Type VALUES (3, 'Design')

INSERT INTO Application VALUES (1,'Tech 1','https://google.com','x64','exe',1)
INSERT INTO Application VALUES (2,'IT 1','https://google.com','x64','exe',2)
INSERT INTO Application VALUES (3,'Design 1','https://google.com','x64','exe',3)
INSERT INTO Application VALUES (4,'Tech 2','https://google.com','x64','exe',1)
INSERT INTO Application VALUES (5,'IT 2','https://google.com','x64','exe',2)
INSERT INTO Application VALUES (6,'Design 2','https://google.com','x64','exe',3)
INSERT INTO Application VALUES (7,'Tech 3','https://google.com','x64','exe',1)
INSERT INTO Application VALUES (8,'IT 3','https://google.com','x64','exe',2)
INSERT INTO Application VALUES (9,'Design 3','https://google.com','x64','exe',3)

INSERT INTO Install VALUES (1, 1, 'ControlClass1.1', 'ControlText1.1', 1389, '926,128', 200)
INSERT INTO Install VALUES (2, 1, 'ControlClass2.1', 'ControlText2.1', 258, '460,1020', 200)
INSERT INTO Install VALUES (3, 1, 'ControlClass3.1', 'ControlText3.1', 888, '172,90', 200)
INSERT INTO Install VALUES (4, 1, 'ControlClass4.1', 'ControlText4.1', 1784, '1877,105', 200)
INSERT INTO Install VALUES (1, 2, 'ControlClass1.2', 'ControlText1.2', 46, '238,575', 200)
INSERT INTO Install VALUES (2, 2, 'ControlClass2.2', 'ControlText2.2', 92, '1356,544', 200)
INSERT INTO Install VALUES (3, 2, 'ControlClass3.2', 'ControlText3.2', 2796, '260,1048', 200)
INSERT INTO Install VALUES (4, 2, 'ControlClass4.2', 'ControlText4.2', 108, '1876,153', 200)
INSERT INTO Install VALUES (1, 3, 'ControlClass1.3', 'ControlText1.3', 1094, '829,448', 200)
INSERT INTO Install VALUES (2, 3, 'ControlClass2.3', 'ControlText2.3', 2897, '830,383', 200)
INSERT INTO Install VALUES (3, 3, 'ControlClass3.3', 'ControlText3.3', 1120, '1853,204', 200)
INSERT INTO Install VALUES (4, 3, 'ControlClass4.3', 'ControlText4.3', 277, '988,863', 200)
INSERT INTO Install VALUES (1, 4, 'ControlClass1.4', 'ControlText1.4', 2145, '1081,971', 200)
INSERT INTO Install VALUES (2, 4, 'ControlClass2.4', 'ControlText2.4', 607, '679,556', 200)
INSERT INTO Install VALUES (3, 4, 'ControlClass3.4', 'ControlText3.4', 1897, '146,382', 200)
INSERT INTO Install VALUES (4, 4, 'ControlClass4.4', 'ControlText4.4', 2712, '391,997', 200)
INSERT INTO Install VALUES (1, 5, 'ControlClass1.5', 'ControlText1.5', 1019, '617,185', 200)
INSERT INTO Install VALUES (2, 5, 'ControlClass2.5', 'ControlText2.5', 2762, '1723,1014', 200)
INSERT INTO Install VALUES (3, 5, 'ControlClass3.5', 'ControlText3.5', 197, '765,328', 200)
INSERT INTO Install VALUES (4, 5, 'ControlClass4.5', 'ControlText4.5', 432, '432,92', 200)
INSERT INTO Install VALUES (1, 6, 'ControlClass1.6', 'ControlText1.6', 594, '1045,702', 200)
INSERT INTO Install VALUES (2, 6, 'ControlClass2.6', 'ControlText2.6', 168, '1077,607', 200)
INSERT INTO Install VALUES (3, 6, 'ControlClass3.6', 'ControlText3.6', 1327, '268,87', 200)
INSERT INTO Install VALUES (4, 6, 'ControlClass4.6', 'ControlText4.6', 1063, '889,220', 200)
INSERT INTO Install VALUES (1, 7, 'ControlClass1.7', 'ControlText1.7', 1070, '45,1025', 200)
INSERT INTO Install VALUES (2, 7, 'ControlClass2.7', 'ControlText2.7', 1648, '257,47', 200)
INSERT INTO Install VALUES (3, 7, 'ControlClass3.7', 'ControlText3.7', 2564, '1800,687', 200)
INSERT INTO Install VALUES (4, 7, 'ControlClass4.7', 'ControlText4.7', 2970, '1811,464', 200)
INSERT INTO Install VALUES (1, 8, 'ControlClass1.8', 'ControlText1.8', 2203, '1040,451', 200)
INSERT INTO Install VALUES (2, 8, 'ControlClass2.8', 'ControlText2.8', 1659, '710,58', 200)
INSERT INTO Install VALUES (3, 8, 'ControlClass3.8', 'ControlText3.8', 216, '390,200', 200)
INSERT INTO Install VALUES (4, 8, 'ControlClass4.8', 'ControlText4.8', 2334, '392,773', 200)
INSERT INTO Install VALUES (1, 9, 'ControlClass1.9', 'ControlText1.9', 693, '1096,258', 200)
INSERT INTO Install VALUES (2, 9, 'ControlClass2.9', 'ControlText2.9', 932, '745,713', 200)
INSERT INTO Install VALUES (3, 9, 'ControlClass3.9', 'ControlText3.9', 2673, '800,981', 200)
INSERT INTO Install VALUES (4, 9, 'ControlClass4.9', 'ControlText4.9', 1828, '168,805', 200)

INSERT INTO InstallStatus VALUES (1, 'Success', 'fail')
INSERT INTO InstallStatus VALUES (2, 'Thanh cong', 'That bai')
INSERT INTO InstallStatus VALUES (3, 'Success', 'fail')       
INSERT INTO InstallStatus VALUES (4, 'Thanh cong', 'That bai')
INSERT INTO InstallStatus VALUES (5, 'Success', 'fail')       
INSERT INTO InstallStatus VALUES (6, 'Thanh cong', 'That bai')
INSERT INTO InstallStatus VALUES (7, 'Success', 'fail')       
INSERT INTO InstallStatus VALUES (8, 'Thanh cong', 'That bai')
INSERT INTO InstallStatus VALUES (9, 'Success', 'fail') 