using System;

class Problem3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string betweenLeafTop = new string ('.', n * 2);
        int midLeafCounter1Q = 2;
        int midLeafCounter2Q = n * 2;
        int skyCounter2Q = 1;
        string pictureMid = new string('.', (n * 2) + 1);
        string pictureBot = new string('.', (n * 2) + 2);

        Console.WriteLine("##" + betweenLeafTop + "##" + betweenLeafTop + "##");

        for (int i = 0; i < n-1; i++)
        {
            string endLeafs1Q = new string ('~', i + 1);
            string midLeaf1Q = new string('.', midLeafCounter1Q);
            midLeafCounter1Q += 2;
            string betweenEndLeaf1Q = new string('.', (n - i - 1) * 2);
            Console.WriteLine("#" + endLeafs1Q + "#" + betweenEndLeaf1Q + "#" + midLeaf1Q + "#" + betweenEndLeaf1Q + "#" + endLeafs1Q + "#");
        }

        for (int e = 0; e < n; e++)
        {
            string sky2Q = new string ('.', skyCounter2Q);
            skyCounter2Q += 2;
            string endLeafs2Q = new string('~', n - e);
            string midLeafe2Q = new string('.', midLeafCounter2Q);
            midLeafCounter2Q -= 2;
            Console.WriteLine(sky2Q + "#" + endLeafs2Q + "#" + midLeafe2Q + "#" + endLeafs2Q + "#" + sky2Q);
        }

        Console.WriteLine(pictureMid + "####" + pictureMid);

        for (int j = 0; j < n; j++)
        {
            Console.WriteLine(pictureBot + "##" + pictureBot);
        }
    }
}