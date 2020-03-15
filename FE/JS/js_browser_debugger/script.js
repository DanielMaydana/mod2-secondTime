(function(){

  const COLORS = {
    primary1: '#025373',
    primary2: '#022840',
    secondary1: '#5B98A6',
    secondary2: '#025e73',
    background1: '#e2e2e25e',
    background2: '#F4F4F5',
    background3: '#E5E5E6',
    background4: '#CBCCCC',
    surface1: '#777777',
    surface2: '#55595C',
    surface3: '#373A3C',
    danger: '#EE2E24',
    warning: '#F58026',
    success: '#00A261'
  }

  const BROWSER_WIDTH = 720
  const BROWSER_HEIGHT = Math.floor(BROWSER_WIDTH * 768/1024)
  
  let isSpinning = false


  let illustrationA = new Zdog.Illustration({
    // set canvas with selector
    element: '.zdog-canvas',
    dragRotate: true,
    onDragStart: function() {
      isSpinning = false
    },
    onDragStart: function () {
      isSpinning = false
    }
  })

  /* TOOLBAR */

  const toolBarHeight = 50
  const toolBarWidth = BROWSER_WIDTH
  const toolBarX = 40
  const toolBarY = - Math.floor(BROWSER_HEIGHT / 2)

  new Zdog.Rect({
    addTo: illustrationA,
    width: toolBarWidth,
    height: toolBarHeight,
    stroke: 0,
    translate: { 
      z: 0,
      y: toolBarY,
      z: toolBarX
    },
    color: COLORS.primary2,
    fill: true,
  })


  /* MENU */

  const menuHeight = BROWSER_HEIGHT - 50
  const menuWidth = 160
  const menuX = - Math.floor(BROWSER_WIDTH / 2 - 80)
  const menuY = 0

  new Zdog.Rect({
    addTo: illustrationA,
    width: menuWidth,
    height: menuHeight,
    stroke: 0,
    translate: { 
      z: -120,
      x: menuX,
      y: menuY
    },
    color: COLORS.background4,
    fill: true,
  })

  /* DISPLAY */

  const displayWidth = BROWSER_WIDTH - menuWidth
  const displayHeight = menuHeight
  const displayX = - Math.floor(displayWidth / 2) + BROWSER_WIDTH / 2
  const displayY = - Math.floor(displayHeight / 2) + BROWSER_HEIGHT / 2 - 25

  new Zdog.Rect({
    addTo: illustrationA,
    width: displayWidth,
    height: displayHeight,
    translate: {
      z: -120,
      x: displayX,
      y: displayY
    },
    stroke: 0,
    color: COLORS.secondary1,
    fill: true,
  })

  /* PORTAL */

  const portalWidth = BROWSER_WIDTH
  const portalHeight = BROWSER_HEIGHT - toolBarHeight
  const portalX = -Math.floor(portalWidth / 2) + (BROWSER_WIDTH / 2)
  const portalY = 0

  new Zdog.Rect({
    addTo: illustrationA,
    width: portalWidth,
    height: portalHeight,
    translate: {
      z: 40,
      x: portalX,
      y: portalY
    },
    stroke: 0,
    color: COLORS.background1,
    fill: true,
  })

  function animate () {
    if (isSpinning) {
      illustrationA.rotate.y += 0.01
    }
    illustrationA.updateRenderGraph()

    requestAnimationFrame(animate)
  }
  
  // update & render
  animate()
})()