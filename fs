#!/bin/bash
if [ ! -d /mnt/ssh ]
then
    sudo mkdir /mnt/ssh
    sudo chown inflation:staff /mnt/ssh
fi

sshfs $1 /mnt/ssh -o reconnect,ciphers=aes128-gcm@openssh.com,compression=no,defer_permissions,auto_cache,noappledouble 
