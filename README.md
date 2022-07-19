# Robô espalha lixo

Controle cinemático de um robô com 6 graus de liberdade feita com Blender + Unity

https://youtu.be/-2m9nsNQjKw


![robô espalha lixo](/medidas.png)

## Tabela de parâmetros DH

| $i$ | $\theta_i$ | $d_i$            | $\alpha_{i-1}$ | $a_{i-1}$ |
|-----|------------|------------------|----------------|-----------|
| $1$ | $\theta_1$ | $offset + 0.20m$ | $-\pi/2$       | $0.15m$   |
| $2$ | $\theta_2$ | $0.10m$          | $-\pi/2$       | $0.20m$   |
| $3$ | $\theta_3$ | $0.20m$          | $\pi/2$        | $0.10m$   |
| $4$ | $\theta_4$ | $0.10m$          | $\pi/2$        | $0.20m$   |
| $5$ | $\theta_5$ | $0.20m$          | $-\pi/2$       | $0.10m$   |
| $6$ | $\theta_6$ | $0$              | $0$            | $0.20m$   |
