namespace RCorpFoodPricer
{
    using System;

    public class App
    {
        
        //calcule le prix payé par l'utilisateur dans le restaurant, en fonction de type de 
        //repas qu'il prend (assiette ou sandwich), de la taille de la boisson (petit, moyen, grand), du dessert et
        //de son type (normal ou special) et si il prend un café ou pas (yes ou no).
        //les prix sont fixes pour chaque type de chose mais des réductions peuvent s'appliquer
        //si cela rentre dans une formule!
        public double Compute(string type, string name, string beverage, string size, string dessert, string dsize, string coffee)
        {
            //prix total à payer pour le client
            int total = 0;
            
            //le type ne peut être vide car le client doit déclarer au moins un repas
            if(string.IsNullOrEmpty(type+name)) return -1;

            //si le client prends un plat en assiette
            if(type=="assiette")
            {
                total+=15;
                //ainsi qu'une boisson de taille:
                switch(size)
                {
                    case "petit": 
                        total+=2;
                        //dans ce cas, on applique la formule standard
                        if(dsize=="normal")
                        {
                            //pas de formule
                            //on ajoute le prix du dessert normal
                            total+=2;
                        } else {
                            //sinon on rajoute le prix du dessert special
                            total+=4;
                        }
                        break;
                    //si on prends moyen
                    case "moyen": 
                        total+=3;
                        //dans ce cas, on applique la formule standard
                        if(dsize=="normal")
                        {
                            //j'affiche la formule appliquée
                            Console.Write("Prix Formule Standard appliquée ");
                            //le prix de la formule est donc 18
                            total=18;
                        } else {
                            //sinon on rajoute le prix du dessert special
                            total+=4;
                        }
                        break;
                    case "grand": 
                        total+=4;
                        //dans ce cas, on applique la formule standard
                        if(dsize=="normal")
                        {
                            //pas de formule
                            //on ajoute le prix du dessert normal
                            total+=2;
                        } else {
                            //dans ce cas on a la fomule max
                            Console.Write("Prix Formule Max appliquée ");
                            total=21;
                        }
                        break;
                }
            } 
            //mode sandwich
            else {
                total+=10;
                //ainsi qu'une boisson de taille:
                switch(size)
                {
                    case "petit": 
                        total+=2;
                        //dans ce cas, on applique la formule standard
                        if(dsize=="normal")
                        {
                            //pas de formule
                            //on ajoute le prix du dessert normal
                            total+=2;
                        } else {
                            //sinon on rajoute le prix du dessert special
                            total+=4;
                        }
                        break;
                    //si on prends moyen
                    case "moyen": 
                        total+=3;
                        //dans ce cas, on applique la formule standard
                        if(dsize=="normal")
                        {
                            //j'affiche la formule appliquée
                            Console.Write("Prix Formule Standard appliquée ");
                            //le prix de la formule est donc 18
                            total=13;
                        } else {
                            //sinon on rajoute le prix du dessert special
                            total+=4;
                        }
                        break;
                    case "grand": 
                        total+=4;
                        //dans ce cas, on applique la formule standard
                        if(dsize=="normal")
                        {
                            //pas de formule
                            //on ajoute le prix du dessert normal
                            total+=2;
                        } else {
                            //dans ce cas on a la fomule max
                            Console.Write("Prix Formule Max appliquée ");
                            total=16;
                        }
                        break;
                }
            }
            if(type=="assiette" && size=="moyen" && dsize=="normal" && coffee=="yes")
            {
                Console.Write(" avec café offert!");
            } else {
                total+=1;
            }
            return total;
        }
    }
}