using System;

class hash
{
  //private  string x;
  private  const int p = 37;
  private  const int modulus = (int)1e9+9;

  private int hash_value = 0;
  private int p_pow = 1;

  

public int compute_hash(string x)
{
  foreach(char c in x)
  {
    hash_value = (hash_value+(c-'a'+1)*p_pow)%modulus;
    p_pow=(p_pow*p)%modulus;
  }
  return hash_value;


}
}
