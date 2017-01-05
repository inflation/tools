#!/usr/bin/env bash
if [ ! -d /tmp/ssh ]
then
    mkdir /tmp/ssh
fi

sshfs $1:/home/inflation /tmp/ssh
