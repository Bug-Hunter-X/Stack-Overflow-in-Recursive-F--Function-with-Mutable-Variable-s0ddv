let rec loop acc x =
  if x < 1000000 then
    loop (acc + 1) (acc + 1)
  else
    printfn "%d" acc
loop 0 0