﻿DELETE FROM WEB_OLD_CODE;
DELETE FROM WEB_BIOT_RELATION;
DELETE FROM WEB_BIOT_SPECIES_GRAB;
DELETE FROM WEB_BIOT_SPECIES_OBSERVATION;
DELETE FROM WEB_BIOTOPE_HIERARCHY;
DELETE FROM WEB_BIOTOPE;

GO

INSERT INTO WEB_BIOTOPE
SELECT * FROM [marbiotopedb].dbo.WEB_BIOTOPE bio
WHERE bio.BIOTOPE_KEY IS NOT NULL AND bio.BIOTOPE_KEY != 'BIOTOPE_KEY     ';

GO

INSERT INTO WEB_BIOTOPE_HIERARCHY
SELECT DISTINCT bh.FirstOfBIOTOPE_LIST_ITEM_KEY, bh.FirstOfBIOTOPE_LIST_ITEM_KEY1, originallevel, higherlevel FROM [marbiotopedb].dbo.WEB_BIOTOPE_HIERARCHY bh

GO

INSERT INTO WEB_BIOT_SPECIES_GRAB
SELECT DISTINCT s.BIOTOPE_KEY, ITEM_NAME, FREQ, ABUND, contrib_similarity_STRENGTH, SED_ABUND_SED_ABUND, SORT FROM [marbiotopedb].dbo.WEB_BIOT_SPECIES s
WHERE s.BIOTOPE_KEY IS NOT NULL AND SED_ABUND_SED_ABUND IS NOT NULL;

GO

INSERT INTO WEB_BIOT_SPECIES_OBSERVATION
SELECT DISTINCT s.BIOTOPE_KEY, ITEM_NAME, FREQ, ABUND, contrib_similarity_STRENGTH, SED_ABUND_SED_ABUND, SORT FROM [marbiotopedb].dbo.WEB_BIOT_SPECIES s
WHERE s.BIOTOPE_KEY IS NOT NULL AND SED_ABUND_SED_ABUND IS NULL AND BIOTOPE_KEY != 'JNCCMNCR00000690';

INSERT INTO WEB_BIOT_SPECIES_OBSERVATION
SELECT DISTINCT s.BIOTOPE_KEY, ITEM_NAME, FREQ, ABUND, contrib_similarity_STRENGTH, SED_ABUND_SED_ABUND, SORT FROM [marbiotopedb].dbo.WEB_BIOT_SPECIES s
WHERE BIOTOPE_KEY = 'JNCCMNCR00000690' AND ITEM_NAME != 'Electra pilosa';

INSERT INTO WEB_BIOT_SPECIES_OBSERVATION
SELECT DISTINCT s.BIOTOPE_KEY, ITEM_NAME, FREQ, ABUND, contrib_similarity_STRENGTH, SED_ABUND_SED_ABUND, SORT FROM [marbiotopedb].dbo.WEB_BIOT_SPECIES s
WHERE BIOTOPE_KEY = 'JNCCMNCR00000690' AND ITEM_NAME = 'Electra pilosa' AND  contrib_similarity_STRENGTH = 2;


GO

INSERT INTO WEB_BIOT_RELATION
SELECT DISTINCT BIOTOPE_RELATION_KEY, BIOTOPE_KEY, RELATED_KEY, COMMENT FROM [marbiotopedb].dbo.WEB_BIOT_RELATION

GO

INSERT INTO WEB_OLD_CODE
SELECT DISTINCT BIOTOPE_KEY, OLD_CODE, [VERSION] FROM [marbiotopedb].dbo.WEB_OLD_CODE
WHERE BIOTOPE_KEY IN (SELECT BIOTOPE_KEY FROM WEB_BIOTOPE)
