using System;

public class Class1
{
    public Class1()
    {


         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.LogTo(mesege => Debug.Write(mesege));
    }
}


הזרקת DbContext - Scoped ולא Singleton
מעקב אחר שינויים
טרנזקציה ו-SaveChanges

}
