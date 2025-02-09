let mutable x = 0
let rec loop () =
  x <- x + 1
  if x < 1000000 then
    loop ()
  else
    printfn "%d" x
loop ()