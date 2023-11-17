let calcFedIncTax sl =
    if sl > 216511.0 then
       sl * 0.33
    else
        0.0 

let sl = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

let FedIncTax = List.map calcFedIncTax sl

printfn "sl: %A" sl
printfn "Fed Inc Tax: %A" FedIncTax

    
