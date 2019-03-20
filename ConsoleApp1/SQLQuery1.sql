/* blok komentar
-- linijski komentar
CREATE DATABASE Upisi
GO
*/
USE Upisi;
CREATE TABLE #privremena(
id INT,
ime NCHAR(50),
prezime VARCHAR(50),
mjesto_stanovanja NCHAR(25)
);

INSERT INTO [dbo].[#privremena] ([id], [ime], [prezime], [mjesto_stanovanja]) 
VALUES (0, N'Pero                                              ', 
N'Peric', N'osijek                   ')

SELECT * FROM #privremena