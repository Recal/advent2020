open System.IO 

module Day1 = 
    let getValPart1 (path: string, num: int) =

        let text = File.ReadAllText(path).Split('\n');

   

        for i = 0 to text.Length - 1 do 
            for j = i to text.Length - 1 do

                let c = text.[j] |> int
                let c2 = text.[i] |> int

                if c + c2 = num then 
                   failwithf "Yes: %s %s \n Yes: %d" text.[j] text.[i] (c2 * c)
                else
                   text.[i] |> ignore 
                  
    let getValPart2 (path: string, num: int) =

        let text = File.ReadAllText(path).Split('\n');

   

        for i = 0 to text.Length - 1 do 
            for j = i to text.Length - 1 do
                for p = j to text.Length - 1 do 
                    let c = text.[j] |> int
                    let c2 = text.[i] |> int
                    let c3 = text.[p] |> int

                    if c + c2 + c3 = num then 
                       failwithf "Yes: %s %s %s\n Yes: %d" text.[j] text.[i] text.[p] (c2 * c * c3)
                    else
                       text.[i] |> ignore 
  
  








[<EntryPoint>]
let main _ = 
    Day1.getValPart1("../../../nums1.txt", 2020) 
    Day1.getValPart2("../../../nums2.txt", 2020)
    0
