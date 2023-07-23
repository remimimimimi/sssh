: ns+ ( c-addr1 u1 c-addr2 u2 ... n-times -- c-addr u )
  \G Concatenate n strings together
  1 - 0 ?do s+ loop ;

: -- s" -" ;
: protoversion s" 2.0" ;
: softwareversion s" 0.1.0" ;
: comments s" SSSH-IS-UNSECURE" ;
: protocol-version
  [
    s" SSH" --
    protoversion --
    softwareversion s"  "
    comments s\" \r\n"
    8 ns+
  ] sliteral ;
