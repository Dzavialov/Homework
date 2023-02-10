const info = document.getElementById('info');

const btn = document.getElementById('btn');

const side = document.getElementById('side');

btn.addEventListener('click', function handleClick() {
    if (info.style.display === 'none') {
      info.style.display = 'block';
  
      btn.textContent = 'Hide Information';
    } else {
      info.style.display = 'none';
  
      btn.textContent = 'Show Information';
    }
  });