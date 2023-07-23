require etags.fs

include unix/socket.fs

6 Constant IPPROTO_TCP

\ Handle c function error value (-1)
: ce{ ( value | -1 -- ) -1 = if ;
: ced{ ( value | -1 -- value ) dup e{ ;
: | ( c-addr u -- R:c-addr R:u ) 2>r ;
: }ce ( c-ddr u -- value? ) exception throw then ;
: }ced ( R:c-ddr R:u -- value? ) 2r> }ce ;


: open-socket ( -- socket-fd )
  PF_INET SOCK_STREAM IPPROTO_TCP socket
  ced{ s" cannot create socket" }ce
;

: connect-socket ( socket-fd socket-address -- )
  over -rot sockaddr_in connect
  ce{ s" connect failed" | close }ced ;

\ Create sockaddr_in structre filled with zeros
create socket-address
  socket-address sockaddr_in dup allot erase

12321 htons constant ssh-port

\ XXX: On some architectures byte order may be different To fix that
\ we should use inet_pton function or some of the alternatives to
\ convert string to appropriate binary representation of address.
$100007f constant localhost \ htonl

\ Sends hello to socket
: send-hello-data ( -- )
  AF_INET socket-address family w!
  ssh-port socket-address port w!
  localhost socket-address sin_addr l!

  open-socket
  cr ." Socket opened successfully!"
  dup socket-address connect-socket
  cr ." Socket connected successfully!"

  cr ." Sending to " ssh-port . cr
  dup s" hello" 0 send
  close ;

send-hello-data
2 ms
bye
