using System;

namespace Safari.Animals
{
  public class Residents
  {
    private string _name;
    private string _species;
    private string _sex;
    private string _biome;

    public Residents(string name, string species, string sex, string biome)
    {
      _name = name;
      _species = species;
      _sex = sex;
      _biome = biome;
    }
    public string GetName()
    {
      return _name;
    }

    public string GetSpecies()
    { 
      return _species;
    }
    public string GetSex()
    { 
      return _sex;
    }
    public string GetBiome()
    { 
      return _biome;
    }
  }
}