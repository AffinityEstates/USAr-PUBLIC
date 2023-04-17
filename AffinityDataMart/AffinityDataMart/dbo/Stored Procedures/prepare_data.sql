CREATE   PROCEDURE prepare_data
as
BEGIN
  DECLARE @i INT = 100;

  WHILE @i < 100000 
  BEGIN
    INSERT INTO affinityTestTable (val) VALUES (@i);


    SET @i = @i + 1;
  END 
END;