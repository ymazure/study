using Builder;

var builder = new House.HouseBuilder();

// Building different houses with builders

builder
  .BuildWindows()
  .BuildLivingroom()
  .BuildGarage()
  .BuildBathroom();

var house1 = builder.GetResultHouse();

builder
  .BuildKitchen()
  .BuildDors();

var house2 = builder.GetResultHouse();
