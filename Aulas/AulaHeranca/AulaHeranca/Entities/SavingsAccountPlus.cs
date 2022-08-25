namespace AulaHeranca.Entities
{
    class SavingsAccountPlus : SavingsAccount
    {

        //Estudo sobre sealed, onde não é sobrescrever novamente o metodo, pois está
        //selado na classe SavingsAccout. O exemplo abaixo mostra que se o comentario for retirado, 
        // não sera possivel utilizar o metodo que ja foi sobrescrito antes e está selado com "sealed".

        /*public sealed override void Withdraw(double amount)
        {
            Balance -= amount;
        }*/
    }
}
