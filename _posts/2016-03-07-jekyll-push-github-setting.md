---
layout: post
title: "jekyll push github setting"
description: "筆記使用jekyll新增內容後，在local git要push到github的帳密碼設定"
category: version-control
tags: [jekyll,git,github]
---
{% include JB/setup %}

#### 設定檔位置

    .git/config

#### 設定內容

    [user]
    name = github帳號
    password = github密碼
    [credential]
    helper = store

這樣之後push上github就不用每次輸入帳號密碼了