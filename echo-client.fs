require etags.fs

include unix/socket.fs

6 Constant IPPROTO_TCP

: open-socket ( -- socket-fd )
  PF_INET SOCK_STREAM IPPROTO_TCP socket

  dup -1 = if
    s" cannot create socket" exception throw
  then ;

: connect-socket ( socket-fd socket-address -- )
  over -rot sockaddr_in connect

  dup -1 = if
    close
    s" connect failed" exception throw
  then drop ;

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
bye
