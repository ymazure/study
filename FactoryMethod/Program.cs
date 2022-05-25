
IUserStorage storage = GetUserStorage();

foreach(var user in storage.GetUsers())
{
  Console.WriteLine(user.ToString());
}


// Factory method
IUserStorage GetUserStorage()
{
  bool useDb = true;

  if (useDb)
  {
    return new DbUserStorage();
  }
  else
  {
    return new RemoteAPIUserStorage();
  }
}

public interface IUserStorage
{
  object[] GetUsers();
}

public class DbUserStorage : IUserStorage
{
  public object[] GetUsers()
  {
    // get users from the db
    throw new NotImplementedException();
  }
}

public class RemoteAPIUserStorage : IUserStorage
{
  public object[] GetUsers()
  {
    // get users from api calls
    throw new NotImplementedException();
  }
}


