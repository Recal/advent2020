open System.IO 

module Day1 = 
    let getVal (path: string, num: int) =

        let text = File.ReadAllText(path).Split('\n');

   

        for i = 0 to text.Length - 1 do 
            for j = i to text.Length - 1 do

                let c = text.[j] |> int
                let c2 = text.[i] |> int

                if c + c2 = num then 
                   failwithf "Yes: %s %s \n Yes: %d" text.[j] text.[i] (c2 * c)
                else
                   text.[i] |> ignore 
  








[<EntryPoint>]
let main _ = 
    Day1.getVal("../../../nums.txt", 2020) 

    0
