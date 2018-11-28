/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF '$(LoadTestData)' = 'true'
BEGIN

DELETE FROM PLAYERS;
DELETE FROM GAMES

SET IDENTITY_INSERT PLAYERS ON

INSERT INTO PLAYERS (PLAYERID, NAME, TEAM, PENDINGAPPROVAL) VALUES
('Wakka', 'Besaid Aurochs', 'REJECTED'),
('Tidus', 'Besaid Aurochs', 'AUTHORISED'),
('Datto', 'Besaid Aurochs', 'AUTHORISED'),
('Letty', 'Besaid Aurochs', 'AUTHORISED'),
('Jassu', 'Besaid Aurochs', 'AUTHORISED'),
('Botta', 'Besaid Aurochs', 'AUTHORISED'),
('Keepa', 'Besaid Aurochs', 'AUTHORISED')

SET IDENTITY_INSERT PLAYERS OFF

INSERT INTO GAMES (DATEANDTIME, LOCATION, FEEPAYER, FEE, FORFEIT) VALUES
('2018-11-26 11:37:50', 'Luca Stadium', 'Tidus', $500, 0)

END;